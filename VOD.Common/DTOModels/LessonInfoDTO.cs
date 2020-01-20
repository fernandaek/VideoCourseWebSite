using System;
using System.Collections.Generic;
using System.Text;

namespace VOD.Common.DTOModels
{
    public class LessonInfoDTO
    {
        public int LessonNumber { get; set; }
        public int NumberOfLessons { get; set; }
        public int PreviousVideoId { get; set; } //For the previous button
        public int NextVideoId { get; set; } //For the next video button
        public string NextVideoTitle { get; set; }
        public string NextVideoThumbnail { get; set; }

        public string CurrentVideoTitle { get; set; }
        public string CurrentVideoThumbnail { get; set; }
    }
}
