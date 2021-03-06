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

namespace Click2Cloud.EnterpriseApp.WebAPI.Models
{
    public class Project_Master
    {
        public int i_ID
        {
            get;
            set;
        }

        public string s_Display_Project_ID
        {
            get;
            set;
        }

        public string s_Project_Title
        {
            get;
            set;
        }

        public string s_Short_Title
        {
            get;
            set;
        }

        public int i_Project_Category_ID
        {
            get;
            set;
        }

        public int i_Project_Type_ID
        {
            get;
            set;
        }

        public int i_Project_Subtype_ID
        {
            get;
            set;
        }

        public bool b_Collaboration_Involved
        {
            get;
            set;
        }

        public bool b_StartBy_TTSH
        {
            get;
            set;
        }

        public bool b_Funding_req
        {
            get;
            set;
        }

        public bool b_Ischild
        {
            get;
            set;
        }

        public int i_Parent_ProjectID
        {
            get;
            set;
        }

        public string s_Project_Alias1
        {
            get;
            set;
        }

        public string s_Project_Alias2
        {
            get;
            set;
        }

        public string s_Project_Desc
        {
            get;
            set;
        }

        public int b_IsFeasible
        {
            get;
            set;
        }

        public bool b_Isselected_project
        {
            get;
            set;
        }

        public string s_IRB_No
        {
            get;
            set;
        }

        public string s_Research_IO
        {
            get;
            set;
        }
        public string s_Research_IP
        {
            get;
            set;
        }
        public string s_CreatedBy_ID
        {
            get;
            set;
        }
        public string s_ModifyBy_ID
        {
            get;
            set;
        }
        public DateTime dt_Created_Date
        {
            get;
            set;
        }
        public DateTime dt_Modify_Date
        {
            get;
            set;
        }
        public string Project_StartDate { get; set; }
        public string Project_Category_Name { get; set; }
        public string Project_Type { get; set; }
        public int i_ProjectStatus { get; set; }
        public string Dt_ProjectEndDate { get; set; }
        public string PI_NAME { get; set; }
    }
}
