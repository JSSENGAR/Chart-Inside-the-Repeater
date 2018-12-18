<!--Chart on aspx page-->
  <!--<asp:Repeater ID="RepMSDetails" runat="server">          
             <ItemTemplate>              -->

<asp:Chart ID="AChart" runat="server"  Height="220"  Width="500">
                                                                            <Titles>
                                                                                <asp:Title Name="Graphical Analysis" Text="Graphical Analysis" ToolTip="Graphical Analysis" BackColor="204, 204, 204" />
                                                                            </Titles>
                                                                            <ChartAreas>
                                                                                <asp:ChartArea Name="ChartArea1" />
                                                                            </ChartAreas>
                                                                            <Legends>
                                                                                <asp:Legend Alignment="Center" Docking="Bottom" IsTextAutoFit="true" LegendStyle="Row" Name="Default" />
                                                                                <asp:Legend Alignment="Center" Docking="Bottom" IsTextAutoFit="true" LegendStyle="Row"  Name="Default1" />
                                                                                <asp:Legend Alignment="Center" Docking="Bottom" IsTextAutoFit="true" LegendStyle="Row"  Name="Default2" />
                                                                            </Legends>
                                                                            <series>
                                                                                <asp:Series Name="Highest">
                                                                                </asp:Series>
                                                                                <asp:Series Name="Average">
                                                                                </asp:Series>
                                                                                <asp:Series Name="Obtained">
                                                                                </asp:Series>
                                                                            </series>
                                                                        </asp:Chart>
																		<!--</ItemTemplate>                                
                                                </asp:Repeater> -->