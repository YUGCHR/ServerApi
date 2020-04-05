using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApi.Models
{
    public class BookText
    {
        public long Id { get; set; }

        public int LanguageId { get; set; }

        public string sentenceText { get; set; }        
    }
}

