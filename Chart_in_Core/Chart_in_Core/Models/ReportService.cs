using Chart_in_Core.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Data;

namespace Satistic.Models
{
    public class ReportService : IReportService
    {
        private readonly IsfDashbord_DbContext _context;
        public ReportService(IsfDashbord_DbContext context)
        {
            _context = context;
        }

        public List<MoadiDetailsDto> GetDetails(string Sh_ezharname)
        {
            List<MoadiDetailsDto> Lst_Result = new List<MoadiDetailsDto>();

            using (var command = this._context.Database.GetDbConnection().CreateCommand())
            {
                command.CommandText = "Sp_MoadiDetails";
                command.CommandType = System.Data.CommandType.StoredProcedure;
                var parameter = new SqlParameter("@ShenaseEzharnameh", Sh_ezharname);
                command.Parameters.Add(parameter);

                this._context.Database.OpenConnection();

                using (var result = command.ExecuteReader())
                {
                    while (result.Read())
                    {
                        //Lst_Result.Add(result.IsDBNull("e_DarkhastEterazNo") ? "" : result.GetString(result.GetOrdinal("e_DarkhastEterazNo")));
                        for (int i = 0; i < result.FieldCount; i++)
                        {
                            MoadiDetailsDto mdto = new();
                            mdto.Field_Name = result.GetName(i);
                            mdto.Field_Value = result[i].ToString();
                            Lst_Result.Add(mdto);
                        }
                    }
                }
            }
            return Lst_Result;
        }

        public List<MoadiShenaseDto> lookup(string ncode,string sal,string source,string dore)
        {
            if (ncode == null || sal==null || source==null || dore==null)
                return null;
            List<MoadiShenaseDto> Lst_Result = new List<MoadiShenaseDto>();

            using (var command = this._context.Database.GetDbConnection().CreateCommand())
            {
                command.CommandText = "Sp_GetMoadiShenase";
                command.CommandType = System.Data.CommandType.StoredProcedure;
                var param1 = new SqlParameter("@Shenase", ncode);
                var param2 = new SqlParameter("@Sal", sal);
                var param3 = new SqlParameter("@Source", source);
                var param4 = new SqlParameter("@Dore", dore);
                command.Parameters.Add(param1);
                command.Parameters.Add(param2);
                command.Parameters.Add(param3);
                command.Parameters.Add(param4);

                this._context.Database.OpenConnection();

                using (var result = command.ExecuteReader())
                {
                    while (result.Read())
                    {
                        MoadiShenaseDto msdto = new MoadiShenaseDto();
                        msdto.RahgiriNo = result.GetString(result.GetOrdinal("RahgiriNo"));
                        msdto.TIN = result.GetString(result.GetOrdinal("TIN"));
                        msdto.ShenaseEzharname = result.GetString(result.GetOrdinal("ShenaseEzharname"));
                        msdto.MosharekatMember = result.GetString(result.GetOrdinal("MosharekatMember"));
                        Lst_Result.Add(msdto);
                    }
                }
            }
            return  Lst_Result;
        }
    }
}
