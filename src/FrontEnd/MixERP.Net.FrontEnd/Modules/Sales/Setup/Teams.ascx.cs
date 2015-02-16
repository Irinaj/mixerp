﻿/********************************************************************************
Copyright (C) Binod Nepal, Mix Open Foundation (http://mixof.org).

This file is part of MixERP.

MixERP is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

MixERP is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with MixERP.  If not, see <http://www.gnu.org/licenses/>.
***********************************************************************************/

using MixERP.Net.FrontEnd.Base;
using MixERP.Net.WebControls.ScrudFactory;
using System;
using System.Reflection;
using MixERP.Net.FrontEnd.Controls;

namespace MixERP.Net.Core.Modules.Sales.Setup
{
    public partial class Teams : MixERPUserControl
    {
        public override void OnControlLoad(object sender, EventArgs e)
        {
            this.LoadControl();
        }

        protected void LoadControl()
        {
            using (Scrud scrud = new Scrud())
            {
                scrud.KeyColumn = "sales_team_id";
                scrud.TableSchema = "core";
                scrud.Table = "sales_teams";
                scrud.ViewSchema = "core";
                scrud.View = "sales_team_scrud_view";

                scrud.Text = Resources.Titles.SalesTeams;
                scrud.ResourceAssembly = Assembly.GetAssembly(typeof(Teams));

                this.ScrudPlaceholder.Controls.Add(scrud);
            }
        }
    }
}