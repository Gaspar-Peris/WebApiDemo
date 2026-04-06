using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.Dto
{
    public class CategoryResponseDto
    {
        public required int IdCategory { get; set; }
        public required string Name { get; set; }
    }
}
