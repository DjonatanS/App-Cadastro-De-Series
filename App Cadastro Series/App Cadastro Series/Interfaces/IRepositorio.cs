using System;
using System.Collections.Generic;
using App_Cadastro_Series.Classes;

namespace App_Cadastro_Series.Interfaces
{
    interface IRepositorio<T>
    {
        List<T> Lista();
        T RetornaPorId(int id);
        void Insere(T objeto);
        void Exclui(int id);
        void Atualiza(int id, T objeto);
        int ProximoId();
    }
}
