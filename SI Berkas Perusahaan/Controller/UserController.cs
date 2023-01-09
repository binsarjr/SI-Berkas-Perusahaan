using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SI_Berkas_Perusahaan.Model.Repository;
using SI_Berkas_Perusahaan.Model.Context;
using System.Windows.Forms;

namespace SI_Berkas_Perusahaan.Controller
{
    public class UserController
    {
        private UserRepository _repository;

        public bool Attempt(string username, string password)
        {
            int result = 0;

            using (DbContext context = new DbContext())
            {
                _repository = new UserRepository(context);
                result = _repository.ReadAttempt(username, password);
            }

            if (result == 1)
                MessageBox.Show("Login Berhasil !", "Informasi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Username dan Password tidak ditemukan !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result == 1;
        }

    }
}
