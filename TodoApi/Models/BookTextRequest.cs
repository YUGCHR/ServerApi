using System.Collections.Generic;
using TodoApi.Models;

namespace TodoApi.Models
{
    public class BookTextRequest
    {
        public int LanguageId { get; set; }
        public List<TextSentence> Text { get; set; }
    }
}
