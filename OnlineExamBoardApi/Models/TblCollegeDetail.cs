using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.OpenApi;
using Microsoft.EntityFrameworkCore;
using OnlineExamBoardApi.Models;

namespace OnlineExamBoardApi.Models;

public partial class TblCollegeDetail
{
    public int IntId { get; set; }

    public string? StrCollegeName { get; set; }

    public string? StrCollegeAddress { get; set; }

    public string? StrAffiliationNumber { get; set; }

    public string? StrContactNo { get; set; }

    public string? StrEmail { get; set; }

    public string? StrPhoneNo { get; set; }

    public bool? IsActive { get; set; }

    public int? IntCreatedBy { get; set; }

    public DateTime? DteCreatedDate { get; set; }

    public int? IntModifiedBy { get; set; }

    public DateTime? DteModifiedDate { get; set; }

    public virtual TblUser? IntCreatedByNavigation { get; set; }

    public virtual TblUser? IntModifiedByNavigation { get; set; }

    public virtual ICollection<TblExamResult> TblExamResults { get; set; } = new List<TblExamResult>();

    public virtual ICollection<TblStudentDetail> TblStudentDetails { get; set; } = new List<TblStudentDetail>();
}


public static class TblCollegeDetailEndpoints
{
	public static void MapTblCollegeDetailEndpoints (this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/TblCollegeDetail").WithTags(nameof(TblCollegeDetail));

        group.MapGet("/", async (DbOnlineExamBoardContext db) =>
        {
            return await db.TblCollegeDetails.ToListAsync();
        })
        .WithName("GetAllTblCollegeDetails")
        .WithOpenApi();

        group.MapGet("/{id}", async Task<Results<Ok<TblCollegeDetail>, NotFound>> (int intid, DbOnlineExamBoardContext db) =>
        {
            return await db.TblCollegeDetails.AsNoTracking()
                .FirstOrDefaultAsync(model => model.IntId == intid)
                is TblCollegeDetail model
                    ? TypedResults.Ok(model)
                    : TypedResults.NotFound();
        })
        .WithName("GetTblCollegeDetailById")
        .WithOpenApi();

        group.MapPut("/{id}", async Task<Results<Ok, NotFound>> (int intid, TblCollegeDetail tblCollegeDetail, DbOnlineExamBoardContext db) =>
        {
            var affected = await db.TblCollegeDetails
                .Where(model => model.IntId == intid)
                .ExecuteUpdateAsync(setters => setters
                  .SetProperty(m => m.IntId, tblCollegeDetail.IntId)
                  .SetProperty(m => m.StrCollegeName, tblCollegeDetail.StrCollegeName)
                  .SetProperty(m => m.StrCollegeAddress, tblCollegeDetail.StrCollegeAddress)
                  .SetProperty(m => m.StrAffiliationNumber, tblCollegeDetail.StrAffiliationNumber)
                  .SetProperty(m => m.StrContactNo, tblCollegeDetail.StrContactNo)
                  .SetProperty(m => m.StrEmail, tblCollegeDetail.StrEmail)
                  .SetProperty(m => m.StrPhoneNo, tblCollegeDetail.StrPhoneNo)
                  .SetProperty(m => m.IsActive, tblCollegeDetail.IsActive)
                  .SetProperty(m => m.IntCreatedBy, tblCollegeDetail.IntCreatedBy)
                  .SetProperty(m => m.DteCreatedDate, tblCollegeDetail.DteCreatedDate)
                  .SetProperty(m => m.IntModifiedBy, tblCollegeDetail.IntModifiedBy)
                  .SetProperty(m => m.DteModifiedDate, tblCollegeDetail.DteModifiedDate)
                  );
            return affected == 1 ? TypedResults.Ok() : TypedResults.NotFound();
        })
        .WithName("UpdateTblCollegeDetail")
        .WithOpenApi();

        group.MapPost("/", async (TblCollegeDetail tblCollegeDetail, DbOnlineExamBoardContext db) =>
        {
            db.TblCollegeDetails.Add(tblCollegeDetail);
            await db.SaveChangesAsync();
            return TypedResults.Created($"/api/TblCollegeDetail/{tblCollegeDetail.IntId}",tblCollegeDetail);
        })
        .WithName("CreateTblCollegeDetail")
        .WithOpenApi();

        group.MapDelete("/{id}", async Task<Results<Ok, NotFound>> (int intid, DbOnlineExamBoardContext db) =>
        {
            var affected = await db.TblCollegeDetails
                .Where(model => model.IntId == intid)
                .ExecuteDeleteAsync();
            return affected == 1 ? TypedResults.Ok() : TypedResults.NotFound();
        })
        .WithName("DeleteTblCollegeDetail")
        .WithOpenApi();
    }
}