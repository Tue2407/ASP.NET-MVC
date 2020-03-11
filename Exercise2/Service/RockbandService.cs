using Exercise2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Exercise2.Service
{
    public class RockbandService
    {

        public static List<Rockband> getRockbands()
        {
            var rockbands = new List<Rockband>();
            rockbands.Add(new Rockband() { Name = "Led Zeppelin" });
            rockbands.Add(new Rockband() { Name = "The Beatles" });
            rockbands.Add(new Rockband() { Name = "Pink Floyd" });
            rockbands.Add(new Rockband() { Name = "The Jimi Hendrix Experience" });
            rockbands.Add(new Rockband() { Name = "Van Halen" });
            rockbands.Add(new Rockband() { Name = "Queen" });
            rockbands.Add(new Rockband() { Name = "The Eagles" });
            rockbands.Add(new Rockband() { Name = "Metallica" });
            rockbands.Add(new Rockband() { Name = "U2" });
            rockbands.Add(new Rockband() { Name = "Bob Marley and the Wailers" });
            return rockbands;

        }
    }
}