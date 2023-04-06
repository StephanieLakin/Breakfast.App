using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Classes are typically used to define complex types
 * that have both data and behavior. In general, if
 * you need to define a simple data structure, use a record. 
 * If you need to define a complex type with behavior,
 * use a class. If you need a lightweight object that holds
 * a few data fields, use a struct.
 */

namespace BreakfastApp.Models
{
    public record Breakfast(
        string Name, 
        string Description, 
        DateTime  StartDateTime,
        DateTime EndDateTime, 
        Uri Image, 
        List<string> Savory,
        List<string> Sweet
        );

}
