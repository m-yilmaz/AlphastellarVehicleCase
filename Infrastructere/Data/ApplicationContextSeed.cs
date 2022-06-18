using ApplicationCore.Entities;
using ApplicationCore.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructere.Data
{
    public static class ApplicationContextSeed
    {
        public static async Task SeedAsync(ApplicationContext context)
        {
            // If there is any data in the database, the seed method will not work.
            if (await context.Cars.AnyAsync() || await context.Buses.AnyAsync() || await context.Boats.AnyAsync() || await context.Colors.AnyAsync()) return;


            Color blue = new() { ColorName = "blue" };
            Color black = new() { ColorName = "black" };
            Color red = new() { ColorName = "red" };
            Color white = new() { ColorName = "white" };

            await context.AddRangeAsync(blue, black, red, white);
            await context.SaveChangesAsync();


            Car c1 = new() { CarName = "Mercedes E250", Headlight = HeadlightEnum.TurnOff, Wheels = 4, Color = black };

            Car c2 = new() { CarName = "BMW 520", Headlight = HeadlightEnum.TurnOn, Wheels = 4, Color = blue };

            Car c3 = new() { CarName = "Audi A6", Headlight = HeadlightEnum.TurnOff, Wheels = 4, Color = white };

            Buss bu1 = new() { BussName = "Mercedes Travego", Color = white };

            Buss bu2 = new() { BussName = "Mercedes Travego", Color = blue };

            Boat bo1 = new () { BoatName = "Bertram", Color = black };
            Boat bo2 = new () { BoatName = "Boston Whaler", Color = red };

            await context.AddRangeAsync(c1, c2, c3, bu1, bu2, bo1, bo2);
            await context.SaveChangesAsync();
        }
    }
}
