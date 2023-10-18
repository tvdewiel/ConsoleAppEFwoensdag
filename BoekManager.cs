using ConsoleAppEFwoensdag.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEFwoensdag
{
    public class BoekManager
    {
        private BoekContext ctx=new BoekContext();

        public void VoegBoekToe(Boek boek)
        {
            //ctx.Boeken.Add(boek);
            ctx.SaveChanges();
        }
        public Boek GeefBoek(int id)
        {
            var b=ctx.BoekenX.Where(x=>x.Id==id).FirstOrDefault();
            return b;
        }
    }
}
