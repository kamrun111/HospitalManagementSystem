using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
	public class Outdoor_bookingBLL
	{
		private Outdoor_bookingDAL _outdoor_bookingDAL;

		public Outdoor_bookingDAL outdoor_bookingDAL
		{
			get { return _outdoor_bookingDAL; }
			set { _outdoor_bookingDAL = value; }
		}

		public Outdoor_bookingBLL()
		{
			outdoor_bookingDAL = new Outdoor_bookingDAL();
		}
		public List<Outdoor_booking> Getoutdoor_bookingsList()
		{
			try
			{
				return outdoor_bookingDAL.Getoutdoor_bookingsList();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
        public DataSet OPDPatientList(DateTime From, DateTime To)
		{
			try
			{
				return outdoor_bookingDAL.OPDPatientList( From, To);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}

        public DataSet Getoutdoor_bookings()
        {
            try
            {
                return outdoor_bookingDAL.Getoutdoor_bookings();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet GetOutdoorPopulationInfo()
		{
			try
			{
                return outdoor_bookingDAL.GetOutdoorPopulationInfo();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}


        public DataSet GetOutdoorConsultantAll()
		{
			try
			{
                return outdoor_bookingDAL.GetOutdoorConsultantAll();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}

        public DataSet GetOutdoorConsultantPatient(int reffered_doctors_id)
        {
            try
            {
                return outdoor_bookingDAL.GetOutdoorConsultantPatient(reffered_doctors_id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet ItemCharge(int item_id)
        {
            try
            {
                return outdoor_bookingDAL.ItemCharge(item_id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet GetOutDoorPatientInfo(int outdoor_booking_id)
        {
            try
            {
                return outdoor_bookingDAL.GetOutDoorPatientInfo(outdoor_booking_id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet GetOutdoorPatientHSN(int patient_code)
        {
            try
            {
                return outdoor_bookingDAL.GetOutdoorPatientHSN(patient_code);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet BookingPatientNameGet(int reffered_doctors_id, string booking_date)
        {
            try
            {
                return outdoor_bookingDAL.BookingPatientNameGet(reffered_doctors_id, booking_date);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


		public Outdoor_booking Getoutdoor_booking(int outdoor_booking_id)
		{
			try
			{
				return outdoor_bookingDAL.Getoutdoor_booking(outdoor_booking_id);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}


		public int Addoutdoor_booking(Outdoor_booking ooutdoor_booking)
		{
			try
			{
				return outdoor_bookingDAL.Addoutdoor_booking(ooutdoor_booking);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

        public int Addoutdoor_ptient_booking(Outdoor_booking ooutdoor_booking)
        {
            try
            {
                return outdoor_bookingDAL.Addoutdoor_ptient_booking(ooutdoor_booking);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



		public int Updateoutdoor_booking(Outdoor_booking ooutdoor_booking)
		{
			try
			{
				return outdoor_bookingDAL.Updateoutdoor_booking(ooutdoor_booking);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public int OutdoorPaidAmount(Outdoor_booking ooutdoor_booking)
        {
            try
            {
                return outdoor_bookingDAL.OutdoorPaidAmount(ooutdoor_booking);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
		public int Removeoutdoor_booking(Outdoor_booking ooutdoor_booking)
		{
			try
			{
				return outdoor_bookingDAL.Removeoutdoor_booking(ooutdoor_booking);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removeoutdoor_booking(int outdoor_booking_id)
		{
			try
			{
				return outdoor_bookingDAL.Removeoutdoor_booking(outdoor_booking_id);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public List<Outdoor_booking> Deserializeoutdoor_bookings(string Path)
		{
			try
			{
				return GenericXmlSerializer<List<Outdoor_booking>>.Deserialize(Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public void Serializeoutdoor_bookings(string Path, List<Outdoor_booking> outdoor_bookings)
		{
			try
			{
				GenericXmlSerializer<List<Outdoor_booking>>.Serialize(outdoor_bookings, Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
