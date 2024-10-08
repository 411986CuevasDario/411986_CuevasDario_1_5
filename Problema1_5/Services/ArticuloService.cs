﻿
using Problema1_5.Data;
using Problema1_5.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema1_5.Services
{
    public class ArticuloService
    {
        private readonly IArticuloRepository _articuloRepository;

        public ArticuloService()
        {
            _articuloRepository = new ArticuloRepository();
        }

        public List<Articulo> GetAll()
        {
            return _articuloRepository.GetAll(); 
        }
        public bool Save(Articulo cliente)
        {
            return _articuloRepository.Save(cliente);
        }
        public bool Delete(int id)
        {
            return _articuloRepository.Delete(id);

        }
    }
}
