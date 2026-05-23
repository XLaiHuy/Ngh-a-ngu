using BUS;
using DevExpress.Utils.Drawing;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Ribbon.ViewInfo;
using DevExpress.XtraEditors;
using DevExpress.XtraNavBar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {
        public frmMain()
        {
            InitializeComponent();
        }
        FuncBUS _func;
        RoomBUS _room;
        FloorBUS _tang;
        GalleryItem item = null;
        private void frmMain_Load(object sender, EventArgs e)
        {
            _func = new FuncBUS();
            _tang = new FloorBUS();
            _room = new RoomBUS();
            leftMenu();
            loadData();
        }
        public void loadData()
        {
            showRoom();
        }
        public void showRoom()
        {
            _tang = new FloorBUS();
            _room = new RoomBUS();
            var lsTang = _tang.GetAll();
            gControl.Gallery.ItemImageLayout = ImageLayoutMode.ZoomInside;
            gControl.Gallery.ImageSize = new Size(64, 64);
            gControl.Gallery.ShowItemText = true;
            gControl.Gallery.ShowGroupCaption = true;

            foreach (var tang in lsTang)
            {
                var galleryItem = new GalleryItemGroup();
                galleryItem.Caption = tang.FloorName;
                galleryItem.CaptionAlignment = GalleryItemGroupCaptionAlignment.Stretch;
                var lsPhong = _room.getByFloor(tang.FloorID);

                foreach (var phong in lsPhong)
                {
                    var gc_item = new GalleryItem();
                    gc_item.Caption = phong.RoomCode;
                    gc_item.Value = phong.RoomID;
                    if (phong.Status == "Trống")
                    {
                        gc_item.ImageOptions.Image = imageList3.Images[0];
                    }
                    else if (phong.Status == "Cho thuê")
                    {
                        gc_item.ImageOptions.Image = imageList3.Images[1];
                    }
                    else
                    {
                        gc_item.ImageOptions.Image = imageList3.Images[2];
                    }
                    galleryItem.Items.Add(gc_item);
                }
                gControl.Gallery.Groups.Add(galleryItem);
            }
        }
        public void leftMenu()
        {
            int i = 0;
            var _lsParent = _func.getParents();
            foreach (var pr in _lsParent)
            {
                NavBarGroup navGroup = new NavBarGroup(pr.DESCRIPTION);
                navGroup.Tag = pr.FUNC_CODE;
                navGroup.Name = pr.FUNC_CODE;
                navGroup.ImageOptions.LargeImage = imageList1.Images[i];
                navMain.Groups.Add(navGroup);
                i++;
                var _lsChild = _func.getChilds(pr.FUNC_CODE);
                foreach (var ch in _lsChild)
                {
                    NavBarItem navItem = new NavBarItem(ch.DESCRIPTION);
                    navItem.Tag = ch.FUNC_CODE;
                    navItem.Name = ch.FUNC_CODE;
                    navItem.ImageOptions.SmallImage = imageList2.Images[0];
                    navGroup.ItemLinks.Add(navItem);

                }
                navMain.Groups[navGroup.Name].Expanded = true;
            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void navMain_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            string _funcCode = e.Link.Item.Tag.ToString();
            switch (_funcCode)
            {
                case "DATPHONG":
                    {
                        frmBooking datPhong = new frmBooking();
                        datPhong.ShowDialog();
                        break;
                    }

                case "KHACHHANG":
                    {
                        frmCustomer khachHang = new frmCustomer();
                        khachHang.ShowDialog();
                        break;
                    }
                case "LOAIDICHVU":
                    {
                        frmServiceType serviceType = new frmServiceType();
                        serviceType.ShowDialog();
                        break;
                    }
                case "DICHVU":
                    {
                        frmService service = new frmService();
                        service.ShowDialog();
                        break;
                    }
                case "LOAIPHONG":
                    {
                        frmRoomType roomType = new frmRoomType();
                        roomType.ShowDialog();
                        break;
                    }
                case "PHONG":
                    {
                        frmRooms room = new frmRooms();
                        room.ShowDialog();
                        break;
                    }
                case "HOADON":
                    {
                        frmInvoice invoice = new frmInvoice();
                        invoice.ShowDialog();
                        break;
                    }
                case "DOANHTHU":
                    {
                        frmRevenueReport report = new frmRevenueReport();
                        report.ShowDialog();
                        break;
                    }
                case "TANG":
                    {
                        frmTang floor = new frmTang();
                        floor.ShowDialog();
                        break;
                    }
            }
        }

        private void popupMenu1_Popup(object sender, EventArgs e)
        {
            Point point = gControl.PointToClient(Control.MousePosition);
            RibbonHitInfo hitInfo = gControl.CalcHitInfo(point);
            if (hitInfo.InGalleryItem || hitInfo.HitTest == RibbonHitTest.GalleryItem)
            {
                item = hitInfo.GalleryItem;
            }
        }

        private void btnDatPhong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var gc_item = new GalleryItem();
            string id = item.Value.ToString();
            MessageBox.Show(id);
        }
    }
}