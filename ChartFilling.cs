 //code segment for chart filling 
 
 
 
 //require name space //
 using System.Web.UI.DataVisualization.Charting;
 
 SqlCommand cmdptch = new SqlCommand("select ScholarID, SubjectName, Marks, AvgMarks, MAXMarks from MarksRegister", con);
                DataTable dtptch = new DataTable();
                SqlDataAdapter sdaptch = new SqlDataAdapter(cmdptch);
                sdaptch.Fill(dtptch);
                
                (rpItem.FindControl("AChart") as Chart).ChartAreas["ChartArea1"].AxisY.Minimum = 0;
                (rpItem.FindControl("AChart") as Chart).ChartAreas["ChartArea1"].AxisY.Maximum = 50;

                (rpItem.FindControl("AChart") as Chart).DataSource = dtptch ;

                (rpItem.FindControl("AChart") as Chart).Series[0].ChartType = SeriesChartType.Column;                
                (rpItem.FindControl("AChart") as Chart).Series[0].XValueMember = "SubjectName";
                (rpItem.FindControl("AChart") as Chart).Series[0].YValueMembers = "MAXMarks";                
                (rpItem.FindControl("AChart") as Chart).Series[0].IsValueShownAsLabel = true;

                (rpItem.FindControl("AChart") as Chart).Series[1].ChartType = SeriesChartType.Column;                
                (rpItem.FindControl("AChart") as Chart).Series[1].XValueMember = "SubjectName";
                (rpItem.FindControl("AChart") as Chart).Series[1].YValueMembers = "AvgMarks";
                (rpItem.FindControl("AChart") as Chart).Series[1].IsValueShownAsLabel = true;


                (rpItem.FindControl("AChart") as Chart).Series[2].ChartType = SeriesChartType.Column;                
                (rpItem.FindControl("AChart") as Chart).Series[2].XValueMember = "SubjectName";
                (rpItem.FindControl("AChart") as Chart).Series[2].YValueMembers = "Marks";
                (rpItem.FindControl("AChart") as Chart).Series[2].IsValueShownAsLabel = true;


                (rpItem.FindControl("AChart") as Chart).DataBind();

                /*string[] x = new string[dtptch.Rows.Count];
                int[] y = new int[dtptch.Rows.Count];
                int[] z = new int[dtptch.Rows.Count];
                int[] p = new int[dtptch.Rows.Count];

                for (int i = 0; i < dtptch.Rows.Count; i++)
                {
                    x[i] = dtptch.Rows[i][1].ToString();
                    y[i] = Convert.ToInt32(dtptch.Rows[i][2]);
                    z[i] = Convert.ToInt32(dtptch.Rows[i][3]);
                    p[i] = Convert.ToInt32(dtptch.Rows[i][4]);
                }

                (rpItem.FindControl("AChart") as Chart).Series[0].Points.DataBindXY(x, y);
                (rpItem.FindControl("AChart") as Chart).Series[0].ChartType = SeriesChartType.Column;
                (rpItem.FindControl("AChart") as Chart).Series[1].Points.DataBindXY(x, z);
                (rpItem.FindControl("AChart") as Chart).Series[1].ChartType = SeriesChartType.Column;
                (rpItem.FindControl("AChart") as Chart).Series[2].Points.DataBindXY(x, p);
                (rpItem.FindControl("AChart") as Chart).Series[2].ChartType = SeriesChartType.Column;



                (rpItem.FindControl("AChart") as Chart).ChartAreas["ChartArea1"].Area3DStyle.Enable3D = true;
                //(rpItem.FindControl("AChart") as Chart).Legends[0].Enabled = true;
                */