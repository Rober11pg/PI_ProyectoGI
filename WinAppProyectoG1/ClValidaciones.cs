using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAppProyectoG1
{
    internal class ClValidaciones
    {
        string[] nom = new string[100];
        string[] ape = new string[100];
        string[] usu = new string[100];
        string[] con = new string[100];
        char[] ge = new char[100];

        public ClValidaciones(string[] n, string[] a, string[] u, string[] ct, char[] g)
        {
            nom = n;
            ape = a;
            usu = u;
            con = ct;
            ge = g;
        }

        public int ValidarUsuario(string usuario, int con)
        {
            for (int i = 0; i < con; i++)
                if (usuario == usu[i])
                    return i;
            return -1;
        }

        /*public bool ValidarContraseña(string contr, int pos)
        {
            if (con[pos] == contr)
                return true;
            return false;
        }*/

        public bool ValidarContraseña(string contr, int pos)
        {
            // Verifica que la posición esté en un rango válido
            if (pos >= 0 && pos < con.Length)
            {
                // Compara la contraseña ingresada con la contraseña del usuario en la posición pos
                return contr == con[pos];
            }

            return false; // Si la posición no es válida, devuelve falso
        }

        public int ValidarNombre(string nomb, int con)
        {
            for (int i = 0; i < con; i++)
                if (nomb == nom[i])
                    return i;
            return -1;
        }
        public void Ordenar(int cont)
        {
            string aux1, aux2, aux3, aux4, aux5, aux6;
            char auxg;
            int auxe;
            for (int i = 0; i < cont; i++)
            {
                for (int j = 0; j < cont - i; j++)
                {
                    if (nom[j].CompareTo(nom[j + 1]) > 0)
                    {
                        aux1 = nom[j];
                        nom[j] = nom[j + 1];
                        nom[j + 1] = aux1;

                        aux2 = ape[j];
                        ape[j] = ape[j + 1];
                        ape[j + 1] = aux2;

                        aux3 = usu[j];
                        usu[j] = usu[j + 1];
                        usu[j + 1] = aux3;

                        aux4 = con[j];
                        con[j] = con[j + 1];
                        con[j + 1] = aux4;

                        auxg = ge[j];
                        ge[j] = ge[j + 1];
                        ge[j + 1] = auxg;
                    }
                }
            }
        }

        public int Eliminar(string nomEl, int canti)
        {
            string[] auxN = new string[100];
            string[] auxA = new string[100];
            string[] auxCr = new string[100];
            string[] auxCn = new string[100];
            char[] auxG = new char[100];
            string[] auxF = new string[100];
            string[] auxR = new string[100];
            int[] auxE = new int[100];
            int conta = 0;
            for (int i = 0; i < canti; i++)
            {
                if (nom[i] != nomEl)
                {
                    auxN[conta] = nom[i];
                    auxA[conta] = ape[i];
                    auxCr[conta] = usu[i];
                    auxCn[conta] = usu[i];
                    auxG[conta] = ge[i];
                    conta++;
                }
            }

            nom = auxN;
            ape = auxA;
            usu = auxCr;
            con = auxCn;
            return conta;
        }
    }
}
