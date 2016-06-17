﻿#region Copyright ©2016, Click2Cloud Inc. - All Rights Reserved
/* ------------------------------------------------------------------- *
*                            Click2Cloud Inc.                          *
*                  Copyright ©2016 - All Rights reserved               *
*                                                                      *
*                                                                      *
*  Copyright © 2016 by Click2Cloud Inc. | www.click2cloud.net          *
*  All rights reserved. No part of this publication may be reproduced, *
*  stored in a retrieval system or transmitted, in any form or by any  *
*  means, photocopying, recording or otherwise, without prior written  *
*  consent of Click2cloud Inc.                                         *
*                                                                      *
*                                                                      *
* -------------------------------------------------------------------  */
#endregion Copyright ©2016, Click2Cloud Inc. - All Rights Reserved

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using System.Data.SqlClient;
using System.Data;
using Click2Cloud.EnterpriseApp.WebAPI.Models;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Click2Cloud.EnterpriseApp.WebAPI.Controllers
{
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        // GET: api/values
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET api/values/nitin?&passWord=abc
        [HttpGet("{userName}")]
        //[HttpPost]
        public User Get(string userName, string passWord)
        {
            SqlDataReader reader = null;
            SqlConnection myConnection = new SqlConnection();
            myConnection.ConnectionString = Files.Config.ConnectionString;
            SqlCommand sqlCmd = new SqlCommand();
            //sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = string.Format("Select Top 1 * from User where userName='{0}' and PassWord='{1}'", userName, passWord);
            sqlCmd.Connection = myConnection;
            myConnection.Open();
            reader = sqlCmd.ExecuteReader();
            User user = null;
            while (reader.Read())
            {
                user = new User();
                user.ID = Int32.Parse(reader.GetValue(0).ToString());
                user.UserName = userName;
                user.Guid = reader.GetValue(3).ToString();
            }
            myConnection.Close();
            return user;
        }

        //[ActionName("GetMenus")]
        [HttpGet]
        public List<AdUserDetail> GetMenus()
        {

            SqlDataReader reader = null;
            SqlConnection myConnection = new SqlConnection();
            myConnection.ConnectionString = Files.Config.ConnectionString;
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCmd.CommandText = "SpGetMenuItems";
            sqlCmd.Connection = myConnection;
            myConnection.Open();

            reader = sqlCmd.ExecuteReader();
            List<AdUserDetail> menus = new List<AdUserDetail>();
            while (reader.Read())
            {
                menus.Add(new AdUserDetail
                {
                    MenuId = (string.IsNullOrEmpty(reader["MenuId"].ToString()) ? 0 : Convert.ToInt32(reader["MenuId"])),
                    MenuName = (string.IsNullOrEmpty(reader["MenuName"].ToString())) ? "" : reader["MenuName"].ToString(),
                    Parent = (string.IsNullOrEmpty(reader["Parent"].ToString()) ? 0 : Convert.ToInt32(reader["Parent"])),
                    Child = (string.IsNullOrEmpty(reader["Child"].ToString()) ? 0 : Convert.ToInt32(reader["Child"])),
                    Url = (string.IsNullOrEmpty(reader["Url"].ToString())) ? "" : reader["Url"].ToString()
                });
            }
            myConnection.Close();
            return menus;
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}