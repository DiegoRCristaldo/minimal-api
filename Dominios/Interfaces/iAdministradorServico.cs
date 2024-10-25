using MinimalAPI.Dominios.DTOs;
using MinimalAPI.Dominios.Entidades;

namespace MinimalAPI.Dominios.Interfaces;

public interface IAdministradorServico
{
    Administrador? Login(LoginDTO loginDTO);
    Administrador Incluir(Administrador administrador);
    Administrador? BuscaPorId(int id);
    List<Administrador> Todos(int? pagina);
}