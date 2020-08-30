using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ImageFileUpload.Models.Validation
{
    [MetadataType(typeof(MetadataImage))]
    public partial class Image
    {
    }

    public class MetadataImage
    {
        public byte[] ImageName { get; set; }
        public System.DateTime MakeDate { get; set; }
    }
}