using UnitSelection.Core;

namespace TestConsole
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Subject> subjects = new List<Subject>();
            subjects.Add(new Subject()
            {
                SubjectName = "Pishrafteh",
                Units = new List<Unit>()
                {
                    new Unit()
                    {
                        ProfName = "Maghsoodi (۱۲۲۱۰۰۳_۰۱)",
                        DayOfUnit = new List<UnitDay>()
                        {
                            new UnitDay()
                            {
                                Day = 1,
                                Hour = 3
                            },
                            new UnitDay()
                            {
                                Day = 3,
                                Hour = 3
                            }
                        }
                    }
                }
            });
            subjects.Add(new Subject()
            {
                SubjectName = "Kargah",
                Units = new List<Unit>()
                {
                    new Unit()
                    {
                        ProfName = "Chitgar (۱۲۲۱۱۲۸_۰۱)",
                        DayOfUnit = new List<UnitDay>()
                        {
                            new UnitDay()
                            {
                                Day = 0,
                                Hour = 0
                            }
                        }
                    },
                    new Unit()
                    {
                        ProfName = "Chitgar (۱۲۲۱۱۲۸_۰2)",
                        DayOfUnit = new List<UnitDay>()
                        {
                            new UnitDay()
                            {
                                Day = 0,
                                Hour = 1
                            }
                        }
                    },
                    new Unit()
                    {
                        ProfName = "Chitgar (۱۲۲۱۱۲۸_۰3)",
                        DayOfUnit = new List<UnitDay>()
                        {
                            new UnitDay()
                            {
                                Day = 1,
                                Hour = 0
                            }
                        }
                    },
                    new Unit()
                    {
                        ProfName = "Chitgar ۱۲۲۱۱۲۸_۰4",
                        DayOfUnit = new List<UnitDay>()
                        {
                            new UnitDay()
                            {
                                Day = 1,
                                Hour = 1
                            }
                        }
                    },
                }
            });
            subjects.Add(new Subject()
            {
                SubjectName = "Gosaste",
                Units = new List<Unit>()
                {
                    new Unit()
                    {
                        ProfName = "Maghsoodi ۱۲۲۱۰۴۷_۰۱",
                        DayOfUnit = new List<UnitDay>()
                        {
                            new UnitDay()
                            {
                                Day = 1,
                                Hour = 1
                            },
                            new UnitDay()
                            {
                                Day = 3,
                                Hour = 1
                            }
                        }
                    },
                    new Unit()
                    {
                        ProfName = "Kazemi ۱۲۲۱۰۴۷_۰۲",
                        DayOfUnit = new List<UnitDay>()
                        {
                            new UnitDay()
                            {
                                Day = 1,
                                Hour = 2
                            },
                            new UnitDay()
                            {
                                Day = 3,
                                Hour = 2
                            }
                        }
                    }
                }
            });
            subjects.Add(new Subject()
            {
                SubjectName = "Math 2",
                Units = new List<Unit>()
                {
                    new Unit()
                    {
                        ProfName = "Motiei ۱۱۱۱۰۰۲_۰۱",
                        DayOfUnit = new List<UnitDay>()
                        {
                            new UnitDay()
                            {
                                Day = 0,
                                Hour = 1
                            },
                            new UnitDay()
                            {
                                Day = 2,
                                Hour = 3
                            },
                        }
                    },
                    new Unit()
                    {
                        ProfName = "Khademloo ۱۱۱۱۰۰۲_۰۲",
                        DayOfUnit = new List<UnitDay>()
                        {
                            new UnitDay()
                            {
                                Day = 1,
                                Hour = 2,
                            },
                            new UnitDay()
                            {
                                Day = 3,
                                Hour = 0
                            }
                        }
                    },
                    new Unit()
                    {
                        ProfName = "Bakhshandeh ۱۱۱۱۰۰۲_۰۳",
                        DayOfUnit = new List<UnitDay>()
                        {
                            new UnitDay()
                            {
                                Day = 1,
                                Hour = 2
                            },
                            new UnitDay()
                            {
                                Day = 3,
                                Hour = 1
                            }
                        }
                    },
                    new Unit()
                    {
                        ProfName = "Talaei ۱۱۱۱۰۰۲_۰۸",
                        DayOfUnit = new List<UnitDay>()
                        {
                            new UnitDay()
                            {
                                Day = 0,
                                Hour = 0
                            },
                            new UnitDay()
                            {
                                Day = 2,
                                Hour = 0
                            }
                        }
                    },
                    new Unit()
                    {
                        ProfName = "Yadollah ۱۱۱۱۰۰۲_۱۰",
                        DayOfUnit = new List<UnitDay>()
                        {
                            new UnitDay()
                            {
                                Day = 0,
                                Hour = 2
                            },
                            new UnitDay()
                            {
                                Day = 2,
                                Hour = 3
                            }
                        }
                    },
                }
            });
            subjects.Add(new Subject()
            {
                SubjectName = "Physics 2",
                Units = new List<Unit>()
                {
                    new Unit()
                    {
                        ProfName = "Ghoreishi ۱۱۱۱۰۰۴_۰۷",
                        DayOfUnit = new List<UnitDay>()
                        {
                            new UnitDay()
                            {
                                Day = 0,
                                Hour = 2
                            },
                            new UnitDay()
                            {
                                Day = 3,
                                Hour = 2
                            }
                        }
                    },
                    new Unit()
                    {
                        ProfName = "Ghoreishi ۱۱۱۱۰۰۴_۰8",
                        DayOfUnit = new List<UnitDay>()
                        {
                            new UnitDay()
                            {
                                Day = 0,
                                Hour = 3
                            },
                            new UnitDay()
                            {
                                Day = 3,
                                Hour = 3
                            }
                        }
                    },
                    //new Unit()
                    //{
                    //    ProfName = "mehri ۱۱۱۱۰۰۴_۰۳",
                    //    DayOfUnit = new List<UnitDay>()
                    //    {
                    //        new UnitDay()
                    //        {
                    //            Day = 2,
                    //            Hour = 2
                    //        },
                    //        new UnitDay()
                    //        {
                    //            Day = 4,
                    //            Hour = 1
                    //        }
                    //    }
                    //},
                }
            });
            subjects.Add(new Subject()
            {
                SubjectName = "Diff",
                Units = new List<Unit>()
                {
                    new Unit()
                    {
                        ProfName = "Kalantary ۱۱۱۱۰۰۹_۰۹",
                        DayOfUnit = new List<UnitDay>()
                        {
                            new UnitDay()
                            {
                                Day = 2,
                                Hour = 0
                            },
                            new UnitDay()
                            {
                                Day = 4,
                                Hour = 1
                            }
                        }
                    },new Unit()
                    {
                        ProfName = "Motiei ۱۱۱۱۰۰۹_۰۱",
                        DayOfUnit = new List<UnitDay>()
                        {
                            new UnitDay()
                            {
                                Day = 0,
                                Hour = 0
                            },
                            new UnitDay()
                            {
                                Day = 2,
                                Hour = 0
                            }
                        }
                    },new Unit()
                    {
                        ProfName = "Motiei ۱۱۱۱۰۰۹_۰2",
                        DayOfUnit = new List<UnitDay>()
                        {
                            new UnitDay()
                            {
                                Day = 1,
                                Hour = 0
                            },
                            new UnitDay()
                            {
                                Day = 3,
                                Hour = 0
                            }
                        }
                    },
                }
            });
            subjects.Add(new Subject()
            {
                SubjectName = "Andishe",
                Units = new List<Unit>()
                {
                    new Unit()
                    {
                        ProfName = "heidary ۱۶۱۱۰۰۱_۰۲",
                        DayOfUnit =new List<UnitDay>()
                        {
                            new UnitDay()
                            {
                                Day = 0,
                                Hour = 3
                            }
                        }
                    },
                    //new Unit()
                    //{
                    //    ProfName = "heidary ۱۶۱۱۰۰۱_۰3",
                    //    DayOfUnit =new List<UnitDay>()
                    //    {
                    //        new UnitDay()
                    //        {
                    //            Day =4,
                    //            Hour = 3
                    //        }
                    //    }
                    //},new Unit()
                    //{
                    //    ProfName = "heidary ۱۶۱۱۰۰۱_۰5",
                    //    DayOfUnit =new List<UnitDay>()
                    //    {
                    //        new UnitDay()
                    //        {
                    //            Day = 4,
                    //            Hour = 0,
                    //        }
                    //    }
                    //},
                }
            });


            RequestUnitSelectDto request = new RequestUnitSelectDto();
            request.Subjects = subjects;
            var result = UnitSelectionServices.SelectUnits(request);
            StreamWriter writer = new StreamWriter("UnitSelectionResult.txt");
            foreach (var UnitGroup in result.UnitGroups)
            {
                foreach (var unit in UnitGroup)
                {
                    Console.WriteLine($"{unit.SubjectName} : {unit.ProfName}");
                    writer.WriteLine($"{unit.SubjectName} : {unit.ProfName}");
                    foreach (var unitDay in unit.DayOfUnit)
                    {
                        Console.Write($" ({unitDay.Day}-{unitDay.Hour})");
                        writer.Write($" ({unitDay.Day}-{unitDay.Hour})");
                    }
                    Console.Write("\n\n");
                    writer.Write("\n\n");
                }

                Console.WriteLine("\n-------------------------------------------\n");
                writer.WriteLine("\n-------------------------------------------\n");
            }
            writer.Close();
        }
    }
}