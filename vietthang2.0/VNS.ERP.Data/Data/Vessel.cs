
using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;
using VNS.Common;
namespace VNS.ERP.Data
{
    #region Vessel
    /// <summary>
    /// This object represents the properties and methods of a Vessel.
    /// </summary>
    public class Vessel : UserTracking2
    {
        public Vessel()
        {
        }



        public Vessel(IDataReader reader)
        {
            this.FromDataReader(reader);
        }

        public override void FromDataReader(IDataReader reader)
        {
            base.FromDataReader(reader);
            if (reader != null && !reader.IsClosed)
            {
                if (!isNull("VesselCode", reader)) vesselCode = reader.GetString(reader.GetOrdinal("VesselCode"));
                if (!isNull("VesselName", reader)) vesselName = reader.GetString(reader.GetOrdinal("VesselName"));
                if (!isNull("Description", reader)) description = reader.GetString(reader.GetOrdinal("Description"));
            }
        }

        #region Public Properties


        public ListBase<string> ColorName2
        {
            get { return null; }

        }
        private string vesselCode = String.Empty;
        /// <summary>
        /// Gets or sets the value of VesselCode
        /// </summary>
        public string VesselCode
        {
            get { return vesselCode; }
            set { vesselCode = value; }
        }

        private string vesselName = String.Empty;
        /// <summary>
        /// Gets or sets the value of VesselName
        /// </summary>
        public string VesselName
        {
            get { return vesselName; }
            set { vesselName = value; }
        }

        private string description = String.Empty;
        /// <summary>
        /// Gets or sets the value of Description
        /// </summary>
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        #endregion

        #region Lists
        #endregion


    }
    #endregion
}

