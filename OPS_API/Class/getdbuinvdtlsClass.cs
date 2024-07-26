using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class getdbuinvdtlsClass
    {
        public string selfgstin { get; set; }
        public string systemcode { get; set; }
        public string branchcode { get; set; }
        public string verticalcode { get; set; }
        public string irngenreg { get; set; }
        //   public string invrefno { get; set; }
        public string trancatg { get; set; }
        public string reversecharge { get; set; }
        public string transactionmode { get; set; }
        public string igstonintra { get; set; }

        // Exp Dtl
        public string expcateg { get; set; }
        public string exppayment { get; set; }
        public string sbno { get; set; }
        public DateTime sbdate { get; set; }
        public string portcode { get; set; }
        public double invamount { get; set; }
        public string forcurr { get; set; }
        public string countrycode { get; set; }
        public string refclm { get; set; }
        public double expduty { get; set; }
        // Exp Dtl
        // Doc dtl
        public string doctype { get; set; }
        public string docno { get; set; }
        public DateTime docdate { get; set; }
        // Doc dtl
        // Supplier dtl //
        public string suppliergstin { get; set; }
        public string suppliername { get; set; }
        public string suppliertradename { get; set; }
        public string supplierloc { get; set; }
        public string supplierpin { get; set; }
        public string supplierstate { get; set; }

        // Supplier dtl //
        // buyer dtl //
        public string buyergstin { get; set; }
        public string buyername { get; set; }
        public string buyertradename { get; set; }
        public string buyerloc { get; set; }
        public string buyerpin { get; set; }
        public string buyerstate { get; set; }
        public string buyerpos { get; set; }

        // buyer dtl //
        // Dispatch dtl //
        public string dispatchgstin { get; set; }
        public string dispatchname { get; set; }
        public string dispatchtradename { get; set; }
        public string dispatchloc { get; set; }
        public string dispatchpin { get; set; }
        public string dispatchstate { get; set; }

        // Dispatch dtl //
        // Ship dtl //
        public string shipgstin { get; set; }
        public string shipname { get; set; }
        public string shiptradename { get; set; }
        public string shiploc { get; set; }
        public string shippin { get; set; }
        public string shipstate { get; set; }

        //// Ship dtl //
        //item //dtls
        public string itemname { get; set; }
        public string itemhsn { get; set; }
        public double itemqty { get; set; }
        public string itemuom { get; set; }
        public double itemrate { get; set; }
        public double grossvalue { get; set; }
        public double assamt { get; set; }
        public string taxability { get; set; }
        public double cgstrate { get; set; }
        public double cgstamount { get; set; }

        public double sgstrate { get; set; }
        public double sgstamount { get; set; }
        public double igstrate { get; set; }
        public double igstamount { get; set; }
        public double cessrate { get; set; }
        public double cessamount { get; set; }
        public double cessnonadval { get; set; }
        public double statecessrate { get; set; }
        public double statecessamount { get; set; }
        public double totalitemval { get; set; }

        //item dtls //

        //val dlts
        public double totalassvalue { get; set; }
        public double cgstvalue { get; set; }
        public double sgstvalue { get; set; }
        public double igstvalue { get; set; }
        public double cessvalue { get; set; }
        public double statecessvalue { get; set; }
        public double cesnonadvalue { get; set; }
        public double totalinvoicevalue { get; set; }
        //val dtls
        //eway bill
        public string ewayreq { get; set; }
        public string subsupplytype { get; set; }
        public string modeoftransport { get; set; }
        public string distanceoftransport { get; set; }
        public string transporterid { get; set; }
        public string transportdocno { get; set; }
        public DateTime transporterdocdate { get; set; }
        public string vehtype { get; set; }
        public string vehnumber { get; set; }
        //eway bill
        public getdbuinvdtlsClass(string self_gstin, string system_code, string branch_code, string vertical_code, string irn_genreg, string tran_catg, string reverse_charge, string transaction_mode, string igst_onintra, string exp_categ, string exp_payment, string sb_no, DateTime sb_date
           , string port_code, double inv_amount, string for_curr, string country_code, string ref_clm, double exp_duty, string doc_type, string doc_no,
             DateTime doc_date//)
            , string supplier_gstin, string supplier_name, string supplier_tradename, string supplier_loc, string supplier_pin, 
            string supplier_state, string buyer_gstin, string buyer_name, string buyer_tradename, 
            string buyer_loc, string buyer_pin, string buyer_state, string buyer_pos, 
            string dispatch_gstin, string dispatch_name, string dispatch_tradename, string dispatch_loc, string dispatch_pin, 
            string dispatch_state, string ship_gstin, string ship_name, string ship_tradename, string ship_loc, string ship_pin, 
            string ship_state,//, 
            
            string item_name, string item_hsn, double item_qty, string item_uom, double item_rate, double gross_value, double ass_amt, 
            string tax_ability, double cgst_rate
            , double cgst_amount, double sgst_rate,
                double sgst_amount,
                double igst_rate,
                double igst_amount,
                double cess_rate,
                 double cess_amount,
                 double cess_nonadval,
                double statecess_rate,
                 double statecess_amount,
                 double total_itemval,//) //,
            double total_assvalue,
            double cgst_value,
            double sgst_value,
            double igst_value,
            double cess_value,
            double state_cessvalue,
            double ces_nonadvalue,
            double total_invoicevalue,
            string eway_req,
              string sub_supplytype,
              string mode_oftransport,
              string distance_oftransport,
              string transporter_id,
              string transport_docno,//,
              DateTime transporter_docdate,
              string veh_type,
              string veh_number
            )
        {
            selfgstin = self_gstin;
            systemcode = system_code;
            branchcode = branch_code;
            verticalcode = vertical_code;
            irngenreg = irn_genreg;
            trancatg = tran_catg;
            reversecharge = reverse_charge;
            transactionmode = transaction_mode;
            igstonintra = igst_onintra;
            // Exp Dtl
            expcateg = exp_categ;
            exppayment = exp_payment;
            sbno = sb_no;
            sbdate = sb_date;
            portcode = port_code;
            invamount = inv_amount;
            forcurr = for_curr;
            countrycode = country_code;
            refclm = ref_clm;
            expduty = exp_duty;
            // Exp Dtl
            // doc dtl
            doctype = doc_type;
            docno = doc_no;
            docdate = doc_date;
            ////// doc dtl
            // Supplier //
            suppliergstin = supplier_gstin;
            suppliername = supplier_name;
            suppliertradename = supplier_tradename;
            supplierloc = supplier_loc;
            supplierpin = supplier_pin;
            supplierstate = supplier_state;
            // Supplier //

            // Buyer //
            buyergstin = buyer_gstin;
            buyername = buyer_name;
            buyertradename = buyer_tradename;
            buyerloc = buyer_loc;
            buyerpin = buyer_pin;
            buyerstate = buyer_state;
            buyerpos = buyer_pos;
            // Buyer //
            // Dispatch //
            dispatchgstin = dispatch_gstin;
            dispatchname = dispatch_name;
            dispatchtradename = dispatch_tradename;
            dispatchloc = dispatch_loc;
            dispatchpin = dispatch_pin;
            dispatchstate = dispatch_state;
            // Dispatch //
            // Ship //
            shipgstin = ship_gstin;
            shipname = ship_name;
            shiptradename = ship_tradename;
            shiploc = ship_loc;
            shippin = ship_pin;
            shipstate = ship_state;
            //  Ship //

            //item//
            itemname = item_name;
            itemhsn = item_hsn;
            itemqty = item_qty;
            itemuom = item_uom;
            itemrate = item_rate;
            grossvalue = gross_value;
            assamt = ass_amt;

            taxability = tax_ability;
            cgstrate = cgst_rate;
            cgstamount = cgst_amount;
            sgstrate = sgst_rate;
            sgstamount = sgst_amount;
            igstrate = igst_rate;
            igstamount = igst_amount;
            cessrate = cess_rate;
            cessamount = cess_amount;
            cessnonadval = cess_nonadval;
            statecessrate = statecess_rate;
            statecessamount = statecess_amount;
            totalitemval = total_itemval;

            //item//
            // valdtl
            totalassvalue = total_assvalue;
            cgstvalue = cgst_value;
            sgstvalue = sgst_value;
            igstvalue = igst_value;
            cessvalue = cess_value;
            statecessvalue = state_cessvalue;
            cesnonadvalue = ces_nonadvalue;
            totalinvoicevalue = total_invoicevalue;

            //valdtl
            //eway bill dtls
            ewayreq = eway_req;
            subsupplytype = sub_supplytype;
            modeoftransport = mode_oftransport;
            distanceoftransport = distance_oftransport;
            transporterid = transporter_id;
            transportdocno = transport_docno;
            transporterdocdate = transporter_docdate;
            vehtype = veh_type;
            vehnumber = veh_number;
            //   eway bill dtls;
        }
    }
}