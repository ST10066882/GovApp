using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GovApp
{
    /// <summary>
    /// Breakdown of what an issue is
    /// </summary>
    public class Issue
    {
        //Attributes
        private string location;
        private string type;
        private string description;
        private byte[] mediaPath;
        private string status;
        public string Location { get => location; set => location = value; }
        public string Type { get => type; set => type = value; }
        public string Description { get => description; set => description = value; }
        public byte[] MediaPath { get => mediaPath; set => mediaPath = value; }
        public string Status { get => status; set => status = value; }

        //---------------------------------------------------------------------------//

        //Defualt Constructor
        public Issue()
        {

        }
        //---------------------------------------------------------------------------//

        //Master Constructor
        public Issue(string location, string type, string description, byte[] mediaPath)
        {
            this.location = location;
            this.type = type;
            this.description = description;
            this.mediaPath = mediaPath;
            this.status = "Pending";
        }
        //---------------------------------------------------------------------------//
        //Method displaying content of object
        override
        public string ToString()
        {
            return
                $"Location: {location}\n" +
                $"Category: {type}\n" +
                $"Description: {description}\n" +
                $"Media: {(mediaPath != null && mediaPath.Length > 0 ? "Image Captured" : "No image")}";
        }

        //---------------------------------------------------------------------------//
        //Saves the image to a file
        public void SaveImageToFile(string filePath)
        {
            if (mediaPath != null && mediaPath.Length > 0)
            {
                System.IO.File.WriteAllBytes(filePath, mediaPath);
            }
        }
        //---------------------------------------------------------------------------//
        // Static method to load an image file as a byte array
        public static byte[] LoadImageFromFile(string filePath)
        {
            return System.IO.File.ReadAllBytes(filePath);
        }
    }
}
