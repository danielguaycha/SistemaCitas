using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProisProject.Controller;
using ProisProject.View.Components;
using ProisProject.Model.Data;
namespace ProisProject.View.Panels
{
    public partial class RolPanel : UserControl
    {
        RolController rc = new RolController();
        PermControlller pc = new PermControlller();
        Dictionary<String, Permisos> perms;
        private int selectedRol = 0;
        private string rolstatus;
        public RolPanel()
        {
            InitializeComponent();
        }

        private string completeString(string v) {
            string temp = "";
            for (int i= 0; i<2-v.Length; i++) {
                temp += "0";
            }
            return "P"+temp + v;
        }

        private void RolPanel_Load(object sender, EventArgs e)
        {
            if (tbRoles.Rows.Count > 0) {
                tbRoles.Rows.Clear();
            }
            // cargando roles!
            foreach (Rol r in rc.get()) {
                tbRoles.Rows.Add(r.id_rol, r.nombre_rol, (r.status == 1)?"Activo": "Inactivo");
            }
            // cargando permisos a la lista
            if (PermListDisp.Items.Count > 0)
                PermListDisp.Items.Clear();
            perms =  pc.get();
            foreach (Permisos desc in perms.Values)
            {
                PermListDisp.Items.Add(completeString(desc.id_permiso+"")+" : "+desc.descripcion);
            }
            PermListDisp.Sorted = true;
        }

        public void addToSave() {
            ListBox.SelectedObjectCollection selectedItems = new ListBox.SelectedObjectCollection(PermListDisp);
            selectedItems = PermListDisp.SelectedItems;
            foreach (String item in selectedItems)
            {
                PermListSelec.Items.Add(item);
            }
            if (PermListDisp.SelectedIndex != -1)
            {
                for (int i = selectedItems.Count - 1; i >= 0; i--)
                    PermListDisp.Items.Remove(selectedItems[i]);
            }
        }
        public void removeToSave() {
            ListBox.SelectedObjectCollection selectedItems = 
                new ListBox.SelectedObjectCollection(PermListSelec);
            selectedItems = PermListSelec.SelectedItems;

            foreach (String item in selectedItems)
            {
                PermListDisp.Items.Add(item);
            }

            if (PermListSelec.SelectedIndex != -1)
            {
                for (int i = selectedItems.Count - 1; i >= 0; i--)
                    PermListSelec.Items.Remove(selectedItems[i]);
            }

        }

        private void btnAddItems_Click(object sender, EventArgs e)
        {
            addToSave();
         //  PermListDisp.Sorted =true;
        }

        private void btnRemoveItems_Click(object sender, EventArgs e)
        {
            removeToSave();
           // PermListSelec.Sorted = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (PermListSelec.Items.Count <= 0) {
                Notification.Show("Necesitas seleccionar los permisos para este rol.", AlertType.warm);
                return;
            }
            if (txtRolName.Text == "") {
                Notification.Show("El nombre del rol es necesario", AlertType.warm);
                return;
            }

            Rol r = new Rol();
            r.nombre_rol = txtRolName.Text;
            int id_rol = rc.store(r);
            List<int> id_perms = new List<int>();
            foreach (String item in PermListSelec.Items) {
                id_perms.Add(int.Parse(item.Split(':')[0].Substring(1)));
            }
            rc.store_RolPermiso(id_perms, id_rol);
            Notification.Show("Rol creado con exito", AlertType.ok);
        }

        private void tbRoles_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            PermListDisp.Items.Clear();
            // select item
            txtRolName.Text = tbRoles.SelectedRows[0].Cells[1].Value.ToString();
            selectedRol = int.Parse(tbRoles.SelectedRows[0].Cells[0].Value.ToString());
            rolstatus = (tbRoles.SelectedRows[0].Cells[2].Value.ToString());
            if (selectedRol == 0) {
                Notification.Show("Seleccione un rol primero.", AlertType.warm);
                return;
            }
            // get and add perms to select list
            List<Permisos> savePerms = rc.getPermsByRol(selectedRol);
            foreach (Permisos per in savePerms) {
                PermListSelec.Items.Add(this.completeString(per.id_permiso + "") + " : " + per.descripcion);
            }

            // load perms in disp list
            foreach (Permisos allperms in perms.Values)
            {
                int bandera = 1;
                foreach (Permisos savepers in savePerms) {
                    if (allperms.id_permiso == savepers.id_permiso)
                    {
                        bandera = 0;
                        break;
                    }
                }
                if (bandera == 1) {
                    PermListDisp.Items.Add(completeString(allperms.id_permiso + "") + " : " + allperms.descripcion);
                }
            }

            if (rolstatus == "Activo")
                btnDelete.ButtonText = "Dar de Baja";
            else
                btnDelete.ButtonText = "Dar de Alta"; 
             // modificate data
            tabRegister.SelectedIndex = 1;
            tabPageRegister.Text = "Modificar/Eliminar Rol";
            btnUpdate.Show();
            btnDelete.Show();
            btnCancel.Show();
            btnSave.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            RolPanel_Load(null, null);
            _clearInputs();
        }

        private void _clearInputs() {
            RolPanel_Load(null, null);
            selectedRol = 0;
            rolstatus = "";
            tabPageRegister.Text = "Registrar Rol";
            tabRegister.SelectedIndex = 0;
            txtRolName.Text = "";
            btnCancel.Hide();
            btnUpdate.Hide();
            btnDelete.Hide();
            btnSave.Show();
            PermListSelec.Items.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedRol > 0)
            {
                // store
                Rol r = new Rol();
                r.nombre_rol = txtRolName.Text;

                List<int> id_perms = new List<int>();
                foreach (String item in PermListSelec.Items)
                {
                    id_perms.Add(int.Parse(item.Split(':')[0].Substring(1)));
                }
                rc.update_RolPermiso(id_perms,r,selectedRol);
                _clearInputs();
                Notification.Show("Rol actualizado con exito", AlertType.ok);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedRol > 0 && rolstatus != "") {
                rc.delete(selectedRol, rolstatus);
                _clearInputs();
                Notification.Show("Has dado de "+((rolstatus=="Activo")?"BAJA":"ALTA")+" el rol", AlertType.ok);
            }
        }
    }
}
