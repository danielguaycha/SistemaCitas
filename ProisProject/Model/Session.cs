using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProisProject.Model.Data;
namespace ProisProject.Model
{
    public static class Session
    {
        public static Usuario user;

        public static void destroy() {
            user = null;
        }

        public static void onStartSession(Usuario u) {
        }
    }
}
