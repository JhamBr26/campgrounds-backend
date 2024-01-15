﻿using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace campground_api.Models;

public partial class Image
{
    public int Id { get; set; }

    public int CampgroundId { get; set; }

    public string Url { get; set; } = null!;

    public string Filename { get; set; } = null!;

    [JsonIgnore]
    public virtual Campground Campground { get; set; } = null!;
}
