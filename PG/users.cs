using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Pg
{
    #region Users
    public class Users
    {
        #region Member Variables
        protected int _id;
        protected string _department;
        protected string _caste;
        protected string _cat;
        protected string _cname;
        protected string _fname;
        protected string _focc;
        protected string _mname;
        protected string _addr;
        protected string _mobno;
        protected string _email;
        protected string _dob;
        protected string _addr;
        protected string _empd;
        protected string _empd;
        protected string _ssc_board;
        protected string _ssc_inst;
        protected string _ssc_div;
        protected string _ssc_agg;
        protected string _ssc_passDate;
        protected string _im_board;
        protected string _im_clg;
        protected string _im_div;
        protected string _im_agg;
        protected string _im_passDate;
        protected string _be_board;
        protected string _be_clg;
        protected string _be_div;
        protected string _be_agg;
        protected string _be_passDate;
        protected string _msc_board;
        protected string _msc_clg;
        protected string _msc_div;
        protected string _msc_agg;
        protected string _msc_passDate;
        protected string _status;
        #endregion
        #region Constructors
        public Users() { }
        public Users(string department, string caste, string cat, string cname, string fname, string focc, string mname, string addr, string mobno, string email, string dob, string addr, string empd, string empd, string ssc_board, string ssc_inst, string ssc_div, string ssc_agg, string ssc_passDate, string im_board, string im_clg, string im_div, string im_agg, string im_passDate, string be_board, string be_clg, string be_div, string be_agg, string be_passDate, string msc_board, string msc_clg, string msc_div, string msc_agg, string msc_passDate, string status)
        {
            this._department=department;
            this._caste=caste;
            this._cat=cat;
            this._cname=cname;
            this._fname=fname;
            this._focc=focc;
            this._mname=mname;
            this._addr=addr;
            this._mobno=mobno;
            this._email=email;
            this._dob=dob;
            this._addr=addr;
            this._empd=empd;
            this._empd=empd;
            this._ssc_board=ssc_board;
            this._ssc_inst=ssc_inst;
            this._ssc_div=ssc_div;
            this._ssc_agg=ssc_agg;
            this._ssc_passDate=ssc_passDate;
            this._im_board=im_board;
            this._im_clg=im_clg;
            this._im_div=im_div;
            this._im_agg=im_agg;
            this._im_passDate=im_passDate;
            this._be_board=be_board;
            this._be_clg=be_clg;
            this._be_div=be_div;
            this._be_agg=be_agg;
            this._be_passDate=be_passDate;
            this._msc_board=msc_board;
            this._msc_clg=msc_clg;
            this._msc_div=msc_div;
            this._msc_agg=msc_agg;
            this._msc_passDate=msc_passDate;
            this._status=status;
        }
        #endregion
        #region Public Properties
        public virtual int Id
        {
            get {return _id;}
            set {_id=value;}
        }
        public virtual string Department
        {
            get {return _department;}
            set {_department=value;}
        }
        public virtual string Caste
        {
            get {return _caste;}
            set {_caste=value;}
        }
        public virtual string Cat
        {
            get {return _cat;}
            set {_cat=value;}
        }
        public virtual string Cname
        {
            get {return _cname;}
            set {_cname=value;}
        }
        public virtual string Fname
        {
            get {return _fname;}
            set {_fname=value;}
        }
        public virtual string Focc
        {
            get {return _focc;}
            set {_focc=value;}
        }
        public virtual string Mname
        {
            get {return _mname;}
            set {_mname=value;}
        }
        public virtual string Addr
        {
            get {return _addr;}
            set {_addr=value;}
        }
        public virtual string Mobno
        {
            get {return _mobno;}
            set {_mobno=value;}
        }
        public virtual string Email
        {
            get {return _email;}
            set {_email=value;}
        }
        public virtual string Dob
        {
            get {return _dob;}
            set {_dob=value;}
        }
        public virtual string Addr
        {
            get {return _addr;}
            set {_addr=value;}
        }
        public virtual string Empd
        {
            get {return _empd;}
            set {_empd=value;}
        }
        public virtual string Empd
        {
            get {return _empd;}
            set {_empd=value;}
        }
        public virtual string Ssc_board
        {
            get {return _ssc_board;}
            set {_ssc_board=value;}
        }
        public virtual string Ssc_inst
        {
            get {return _ssc_inst;}
            set {_ssc_inst=value;}
        }
        public virtual string Ssc_div
        {
            get {return _ssc_div;}
            set {_ssc_div=value;}
        }
        public virtual string Ssc_agg
        {
            get {return _ssc_agg;}
            set {_ssc_agg=value;}
        }
        public virtual string Ssc_passDate
        {
            get {return _ssc_passDate;}
            set {_ssc_passDate=value;}
        }
        public virtual string Im_board
        {
            get {return _im_board;}
            set {_im_board=value;}
        }
        public virtual string Im_clg
        {
            get {return _im_clg;}
            set {_im_clg=value;}
        }
        public virtual string Im_div
        {
            get {return _im_div;}
            set {_im_div=value;}
        }
        public virtual string Im_agg
        {
            get {return _im_agg;}
            set {_im_agg=value;}
        }
        public virtual string Im_passDate
        {
            get {return _im_passDate;}
            set {_im_passDate=value;}
        }
        public virtual string Be_board
        {
            get {return _be_board;}
            set {_be_board=value;}
        }
        public virtual string Be_clg
        {
            get {return _be_clg;}
            set {_be_clg=value;}
        }
        public virtual string Be_div
        {
            get {return _be_div;}
            set {_be_div=value;}
        }
        public virtual string Be_agg
        {
            get {return _be_agg;}
            set {_be_agg=value;}
        }
        public virtual string Be_passDate
        {
            get {return _be_passDate;}
            set {_be_passDate=value;}
        }
        public virtual string Msc_board
        {
            get {return _msc_board;}
            set {_msc_board=value;}
        }
        public virtual string Msc_clg
        {
            get {return _msc_clg;}
            set {_msc_clg=value;}
        }
        public virtual string Msc_div
        {
            get {return _msc_div;}
            set {_msc_div=value;}
        }
        public virtual string Msc_agg
        {
            get {return _msc_agg;}
            set {_msc_agg=value;}
        }
        public virtual string Msc_passDate
        {
            get {return _msc_passDate;}
            set {_msc_passDate=value;}
        }
        public virtual string Status
        {
            get {return _status;}
            set {_status=value;}
        }
        #endregion
    }
    #endregion
}