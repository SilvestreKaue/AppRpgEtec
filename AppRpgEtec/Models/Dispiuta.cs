﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppRpgEtec.Models
{
    internal class Dispiuta;
    
        namespace AppRpgEtec.Models
    {
        public class Disputa
        {
            public int Id { get; set; }
           
public DateTime? DataDisputa { get; set; }
         
public int AtacanteId { get; set; }
         
public int OponenteId { get; set; }
        
public string Narracao { get; set; }
        
public int Habilidadeld { get; set; }
        
public List<int> ListaIdPersonagens { get; set; } = new List<int>();
       
public List<string> Resultados 
    { get; set; } = new List<string>();
        }
    }
}


