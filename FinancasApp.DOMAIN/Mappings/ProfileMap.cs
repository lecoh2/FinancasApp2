using AutoMapper;
using FinancasApp.DOMAIN.DTOs.Requests;
using FinancasApp.DOMAIN.DTOs.Responses;
using FinancasApp.DOMAIN.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancasApp.DOMAIN.Mappings
{
    public class ProfileMap : Profile
    {
        public ProfileMap()
        {
            CreateMap<CategoriaRequest, Categoria>();
            CreateMap<MovimentacaoRequest, Movimentacao>();

            CreateMap<Categoria, CategoriaResponse>();
            CreateMap<Movimentacao, MovimentacaoResponse>();
        }
    }
}
