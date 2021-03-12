using System.Collections.Generic;

namespace TestApp.Models
{
    public class EventDto
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }

    public class CompetitionDto
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public List<EventDto> Events { get; set; }
    }
    
    public class RegionDto
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public List<CompetitionDto> Competitions { get; set; }
    }
    
    public class SportDto
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public List<RegionDto> Regions { get; set; }
    }

    public class ContentDto
    {
        public string Id { get; set; }
        public string Name { get; set; }        
    }
    
    public class CatalogResponseDto
    {
        public List<SportDto> Sports { get; set; }
        public List<ContentDto> Content { get; set; }

        public static CatalogResponseDto FakeCatalogResponse()
        {
            return new CatalogResponseDto
            {
                Sports = new List<SportDto>
                {
                    new SportDto
                    {
                        Id = "1",
                        Name = "Football",
                        Regions = new List<RegionDto>
                        {
                            new RegionDto
                            {
                                Id = "9",
                                Name = "Italy",
                                Competitions = new List<CompetitionDto>
                                {
                                    new CompetitionDto
                                    {
                                        Id = "12",
                                        Name = "Italy Serie A",
                                        Events = new List<EventDto>
                                        {
                                            new EventDto
                                            {
                                                Id = "f-mAKv3sg0zkeJIEI97tAeNA",
                                                Name = "AC Milan - Torino FC"
                                            },
                                            new EventDto
                                            {
                                                Id = "f-B7pwKcDlt02A-bOPy27fWA",
                                                Name = "Atalanta - AC Roma"
                                            }
                                        }
                                    },
                                    new()
                                    {
                                        Id = "14",
                                        Name = "Italy Serie C",
                                        Events = new List<EventDto>()
                                    }
                                }
                            },
                            new RegionDto
                            {
                                Id = "19",
                                Name = "Denmark",
                                Competitions = new List<CompetitionDto>()
                            }
                        }
                    },
                    new SportDto
                    {
                        Id = "4321",
                        Name = "Politics and Business",
                        Regions = new List<RegionDto>
                        {
                            new RegionDto
                            {
                                Id = "121",
                                Name = "United Kingdom",
                                Competitions = new List<CompetitionDto>
                                {
                                    new CompetitionDto
                                    {
                                        Id = "13199",
                                        Name = "UK Politics"
                                    }
                                }
                            }
                        }
                    }
                },
                Content = new List<ContentDto>
                {
                    new ContentDto
                    {
                        Id = "4587",
                        Name = "Settings"
                    },
                    new ContentDto
                    {
                        Id = "32898",
                        Name = "Starting Soon"
                    }
                }
            };
        }
    }
}