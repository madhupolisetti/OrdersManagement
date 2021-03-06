﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersManagement
{
    internal static class StoredProcedure
    {
        #region SERVICES RELATED
        internal const string GET_SERVICES = "GetServices";
        internal const string GET_SERVICE_PROPERTIES = "GetServiceProperties";
        internal const string GET_INPUT_TYPES = "GetInputTypes";
        internal const string GET_INPUT_DATA_TYPES = "GetInputDataTypes";
        internal const string CREATE_SERVICE = "CreateService";
        internal const string UPDATE_SERVICE = "UpdateService";
        internal const string DELETE_SERVICE = "DeleteService";
        internal const string CREATE_SERVICE_PROPERTIES = "CreateServiceProperties";
        internal const string UPDATE_SERVICE_PROPERTY = "UpdateServiceProperty";
        internal const string DELETE_SERVICE_PROPERTY = "DeleteServiceProperty";
        #endregion
        #region QUOTATION RELATED
        internal const string GET_QUOTATION_STATUSES = "GetQuotationStatuses";
        internal const string GET_QUOTATIONS = "GetQuotations";
        internal const string GET_QUOTATION_CHANNELS = "GetQuotatioChannels";
        internal const string CREATE_QUOTATION = "CreateQuotation";
        internal const string UPDATE_QUOTATION = "UpdateQuotation";
        internal const string DELETE_QUOTATION = "DeleteQuotation";
        internal const string GET_QUOTATION_DETAILS = "GetQuotationDetails";
        internal const string VIEW_QUOTATION = "ViewQuotation";
        internal const string VIEW_OR_DOWNLOAD_QUOTATION = "ViewOrDownloadQuotation";
        internal const string VIEW_OR_DOWNLOAD_INVOICE = "ViewOrDownloadInvoice";
        internal const string GET_QUOTATION_SERVICES = "GetQuotationServices";
        internal const string GET_QUOTATION_SERVICE_PROPERTIES = "GetQuotationServiceProperties";
        #endregion
        #region INVOICE RELATED
        internal const string GET_INVOICE_STATUSES = "GetInvoiceStatuses";
        internal const string GET_INVOICE_ACCOUNT_DETAILS = "GetInvoiceAccountDetails";
        internal const string UPDATE_INVOICE = "UpdateInvoice";
        internal const string CREATE_INVOICE = "CreateInvoice";
        internal const string GET_INVOICES = "GetInvoices";
        internal const string CANCEL_INVOICE = "CancelInvoice";
        #endregion
        #region PAYMENTS RELATED
        internal const string GET_BANK_ACCOUNTS = "GetBankAccounts";
        internal const string GET_PAYMENT_GATEWAYS = "GetPaymentGateways";
        internal const string GET_ONLINE_PAYMENT_GATEWAYS = "GetOnlinePaymentGateways";
        internal const string CREATE_PAYMENT = "CreatePayment";
        internal const string GET_PAYMENTS = "GetPayments";
        internal const string GET_PAYMENT_STATUSES = "GetPaymentStatuses";
        internal const string GET_PAYMENT_DETAILS = "GetPaymentDetails";
        internal const string VERIFY_PAYMENT_STATUSES = "VerifyPaymentStatuses";
        #endregion
        #region Orders Related
        internal const string GET_ORDER_STATUSES = "GetOrderStatuses";
        internal const string GET_ORDERS = "GetOrders";
        internal const string GET_ORDER_SUMMARY = "GetOrderSummary";
        internal const string ACTIVATE_ORDER = "ActivateOrder";
        internal const string VERIFY_ORDER_STATUS = "VerifyOrderStatus";
        internal const string ORDERS_LOG = "OrdersLog";
        #endregion
        #region PRODUCTS RELATED
        internal const string GET_PRODUCTS = "GetProducts";
        #endregion
        internal const string GET_BILLING_MODES = "GetBillingModes";
        internal const string GET_COUNTRIES = "GetCountries";
        internal const string GET_STATES = "GetStates";
    }
}
