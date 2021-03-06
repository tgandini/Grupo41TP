﻿using HSH_Desa_y_Test.ContextoDB;
using HSH_Desa_y_Test.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HSH_Desa_y_Test.xUC.Vista_Principal_de_usuario_Logueado_y_Deslogueado;

namespace HSH_Desa_y_Test.Modelo_Expandido
{
    class Sesion
    {
        public static usuario user;
        public static admin admin;
        public static xfPantallaPrincipal vistaPrincipal;
        public static xUC.Vista_principal_de_Administrador.xucVistaPrincipalAdmin vistaPrincipalDeAdmin;
        public static xfmContenedorRegistrarUsuario contenedorRegistrarUsuario;
        public static xucVistaPrincipalUsuario vistaPrincipalUserLogueado;

        public static bool hayUserLogueado()
        {
            return user != null;
        }
        public static bool hayAdminLogueado()
        {
            return admin != null;
        }
        public static void guardarPantallaPrincipal(xfPantallaPrincipal vistaPorParámetro)
        {
            vistaPrincipal = vistaPorParámetro;

        }
        public static xfPantallaPrincipal getVistaPrincipal()
        {
            return vistaPrincipal;
        }
        public static xUC.Vista_principal_de_Administrador.xucVistaPrincipalAdmin getVistaPrincipalDeAdmin()
        {
            return vistaPrincipalDeAdmin;
        }
    }
}
