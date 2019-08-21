using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace InterviewTest.Models
{
    public class BannerRiport
    {
            public IEnumerable<Banner> Banners
            {
                get
                {
                   
                string connectionString = ConfigurationManager.AppSettings["ConnectionString"].ToString();

                List<Banner> banners = new List<Banner>();

                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        SqlCommand cmd = new SqlCommand("BannerClicksAImpression", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        con.Open();
                        SqlDataReader rdr = cmd.ExecuteReader();
                        while (rdr.Read())
                        {
                            Banner banner = new Banner();
                            banner.Name = rdr["Name"].ToString();
                            banner.Link = rdr["Link"].ToString();
                            banner.ImpressionCount = Convert.ToInt32(rdr["ImpressionCount"]);
                            banner.ClickCount = Convert.ToInt32(rdr["ClickCount"]);

                            banners.Add(banner);
                        }
                    }

                    return banners;
                }
            }
        }
    }