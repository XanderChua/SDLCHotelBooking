using System;
using System.Collections.Generic;
using System.Text;

namespace SDLCHotelBooking
{
    class RoomDetailsCollection
    {
        private List<string> _regularList;
        private List<string> _deluxeList;
        private List<string> _suiteList;
        public List<string> RegularObj
        {
            get
            {
                if (_regularList == null)
                {
                    _regularList = new List<string>();
                }
                return _regularList;
            }
            set
            {
                _regularList = value;
            }
        }
        public List<string> DeluxeObj
        {
            get
            {
                if (_deluxeList == null)
                {
                    _deluxeList = new List<string>();
                }
                return _deluxeList;
            }
            set
            {
                _deluxeList = value;
            }
        }
        public List<string> SuiteObj
        {
            get
            {
                if (_suiteList == null)
                {
                    _suiteList = new List<string>();
                }
                return _suiteList;
            }
            set
            {
                _suiteList = value;
            }
        }
        //    private Dictionary<double, Customer> _regulardic;
        //    private Dictionary<double, Customer> _deluxedic;
        //    private Dictionary<double, Customer> _suitedic;
        //    public Dictionary<double, Customer> RegularObj
        //    {
        //        get
        //        {
        //            if (_regulardic == null)
        //            {
        //                _regulardic = new Dictionary<double, Customer>();
        //            }
        //            return _regulardic;
        //        }
        //        private set
        //        {
        //            _regulardic = value;
        //        }
        //    }
        //    public Dictionary<double, Customer> DeluxeObj
        //    {
        //        get
        //        {
        //            if (_deluxedic == null)
        //            {
        //                _deluxedic = new Dictionary<double, Customer>();
        //            }
        //            return _deluxedic;
        //        }
        //        private set
        //        {
        //            _deluxedic = value;
        //        }
        //    }
        //    public Dictionary<double, Customer> SuiteObj
        //    {
        //        get
        //        {
        //            if (_suitedic == null)
        //            {
        //                _suitedic = new Dictionary<double, Customer>();
        //            }
        //            return _suitedic;
        //        }
        //        private set
        //        {
        //            _suitedic = value;
        //        }
        //    }
        //}
    }
}
