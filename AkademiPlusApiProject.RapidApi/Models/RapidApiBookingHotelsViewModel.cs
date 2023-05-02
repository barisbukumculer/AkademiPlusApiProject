namespace AkademiPlusApiProject.RapidApi.Models
{
    public class RapidApiBookingHotelsViewModel
    {

        public Result[] result { get; set; }
        public class Result
        {
            
            public float? review_score { get; set; }
            public int hotel_id { get; set; }
            public string unit_configuration_label { get; set; }
            public int cc_required { get; set; }
            public int wishlist_count { get; set; }
            public int hotel_has_vb_boost { get; set; }
            public string city_in_trans { get; set; }
            public string type { get; set; }
            public string default_wishlist_name { get; set; }
            public object updated_checkout { get; set; }
            public int is_beach_front { get; set; }
            public string main_photo_url { get; set; }
            public string hotel_facilities { get; set; }
            public object updated_checkin { get; set; }
            public string hotel_name { get; set; }
            public int children_not_allowed { get; set; }
            public string max_photo_url { get; set; }
            public string max_1440_photo_url { get; set; }
            public string cpc_non_trader_copy { get; set; }
            public int has_free_parking { get; set; }
        }

    }
}
