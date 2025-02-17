﻿using System.ComponentModel;

namespace Domain.Enum;

/// <summary>
/// Enumeration of ISO 4217 currency codes, indexed with their respective ISO 4217 numeric currency codes. 
/// Only codes support in .Net with RegionInfo objects are listed
/// </summary>
public enum CurrencyCode
{
    [Description("AED - United Arab Emirates dirham")]
    AED = 784,
    [Description("AFN - Afghan afghani")] AFN = 971,
    [Description("ALL - Albanian lek")] ALL = 8,
    [Description("AMD - Armenian dram")] AMD = 51,

    [Description("ANG - Netherlands Antillean guilder")]
    ANG = 532,
    [Description("AOA - Angolan kwanza")] AOA = 973,
    [Description("ARS - Argentine peso")] ARS = 32,

    [Description("AUD - Australian dollar")]
    AUD = 36,
    [Description("AWG - Aruban florin")] AWG = 533,

    [Description("AZN - Azerbaijani manat")]
    AZN = 944,

    [Description("BAM - Bosnia and Herzegovina convertible mark")]
    BAM = 977,
    [Description("BBD - Barbados dollar")] BBD = 52,

    [Description("BDT - Bangladeshi taka")]
    BDT = 50,
    [Description("BGN - Bulgarian lev")] BGN = 975,
    [Description("BHD - Bahraini dinar")] BHD = 48,
    [Description("BIF - Burundian franc")] BIF = 108,

    [Description("BMD - Bermudian dollar")]
    BMD = 60,
    [Description("BND - Brunei dollar")] BND = 96,
    [Description("BOB - Boliviano")] BOB = 68,

    [Description("BOV - Bolivian Mvdol (funds code)")]
    BOV = 984,
    [Description("BRL - Brazilian real")] BRL = 986,
    [Description("BSD - Bahamian dollar")] BSD = 44,

    [Description("BTN - Bhutanese ngultrum")]
    BTN = 64,
    [Description("BWP - Botswana pula")] BWP = 72,

    [Description("BYN - Belarusian ruble")]
    BYN = 933,
    [Description("BZD - Belize dollar")] BZD = 84,
    [Description("CAD - Canadian dollar")] CAD = 124,
    [Description("CDF - Congolese franc")] CDF = 976,

    [Description("CHE - WIR euro (complementary currency)")]
    CHE = 947,
    [Description("CHF - Swiss franc")] CHF = 756,

    [Description("CHW - WIR franc (complementary currency)")]
    CHW = 948,

    [Description("CLF - Unidad de Fomento (funds code)")]
    CLF = 990,
    [Description("CLP - Chilean peso")] CLP = 152,
    [Description("COP - Colombian peso")] COP = 170,

    [Description("COU - Unidad de Valor Real (UVR) (funds code)")]
    COU = 970,

    [Description("CRC - Costa Rican colon")]
    CRC = 188,

    [Description("CUC - Cuban convertible peso")]
    CUC = 931,
    [Description("CUP - Cuban peso")] CUP = 192,

    [Description("CVE - Cape Verdean escudo")]
    CVE = 132,
    [Description("CZK - Czech koruna")] CZK = 203,

    [Description("DJF - Djiboutian franc")]
    DJF = 262,
    [Description("DKK - Danish krone")] DKK = 208,
    [Description("DOP - Dominican peso")] DOP = 214,
    [Description("DZD - Algerian dinar")] DZD = 12,
    [Description("EGP - Egyptian pound")] EGP = 818,
    [Description("ERN - Eritrean nakfa")] ERN = 232,
    [Description("ETB - Ethiopian birr")] ETB = 230,
    [Description("EUR - Euro")] EUR = 978,
    [Description("FJD - Fiji dollar")] FJD = 242,

    [Description("FKP - Falkland Islands pound")]
    FKP = 238,
    [Description("GBP - Pound sterling")] GBP = 826,
    [Description("GEL - Georgian lari")] GEL = 981,
    [Description("GHS - Ghanaian cedi")] GHS = 936,
    [Description("GIP - Gibraltar pound")] GIP = 292,
    [Description("GMD - Gambian dalasi")] GMD = 270,
    [Description("GNF - Guinean franc")] GNF = 324,

    [Description("GTQ - Guatemalan quetzal")]
    GTQ = 320,
    [Description("GYD - Guyanese dollar")] GYD = 328,

    [Description("HKD - Hong Kong dollar")]
    HKD = 344,

    [Description("HNL - Honduran lempira")]
    HNL = 340,
    [Description("HRK - Croatian kuna")] HRK = 191,
    [Description("HTG - Haitian gourde")] HTG = 332,

    [Description("HUF - Hungarian forint")]
    HUF = 348,

    [Description("IDR - Indonesian rupiah")]
    IDR = 360,

    [Description("ILS - Israeli new shekel")]
    ILS = 376,
    [Description("INR - Indian rupee")] INR = 356,
    [Description("IQD - Iraqi dinar")] IQD = 368,
    [Description("IRR - Iranian rial")] IRR = 364,

    [Description("ISK - Icelandic króna (plural: krónur)")]
    ISK = 352,
    [Description("JMD - Jamaican dollar")] JMD = 388,
    [Description("JOD - Jordanian dinar")] JOD = 400,
    [Description("JPY - Japanese yen")] JPY = 392,
    [Description("KES - Kenyan shilling")] KES = 404,
    [Description("KGS - Kyrgyzstani som")] KGS = 417,
    [Description("KHR - Cambodian riel")] KHR = 116,
    [Description("KMF - Comoro franc")] KMF = 174,

    [Description("KPW - North Korean won")]
    KPW = 408,

    [Description("KRW - South Korean won")]
    KRW = 410,
    [Description("KWD - Kuwaiti dinar")] KWD = 414,

    [Description("KYD - Cayman Islands dollar")]
    KYD = 136,

    [Description("KZT - Kazakhstani tenge")]
    KZT = 398,
    [Description("LAK - Lao kip")] LAK = 418,
    [Description("LBP - Lebanese pound")] LBP = 422,

    [Description("LKR - Sri Lankan rupee")]
    LKR = 144,
    [Description("LRD - Liberian dollar")] LRD = 430,
    [Description("LSL - Lesotho loti")] LSL = 426,
    [Description("LYD - Libyan dinar")] LYD = 434,
    [Description("MAD - Moroccan dirham")] MAD = 504,
    [Description("MDL - Moldovan leu")] MDL = 498,
    [Description("MGA - Malagasy ariary")] MGA = 969,

    [Description("MKD - Macedonian denar")]
    MKD = 807,
    [Description("MMK - Myanmar kyat")] MMK = 104,

    [Description("MNT - Mongolian tögrög")]
    MNT = 496,
    [Description("MOP - Macanese pataca")] MOP = 446,

    [Description("MRU - Mauritanian ouguiya")]
    MRU = 929,
    [Description("MUR - Mauritian rupee")] MUR = 480,

    [Description("MVR - Maldivian rufiyaa")]
    MVR = 462,
    [Description("MWK - Malawian kwacha")] MWK = 454,
    [Description("MXN - Mexican peso")] MXN = 484,

    [Description("MXV - Mexican Unidad de Inversion (UDI) (funds code)")]
    MXV = 979,

    [Description("MYR - Malaysian ringgit")]
    MYR = 458,

    [Description("MZN - Mozambican metical")]
    MZN = 943,
    [Description("NAD - Namibian dollar")] NAD = 516,
    [Description("NGN - Nigerian naira")] NGN = 566,

    [Description("NIO - Nicaraguan córdoba")]
    NIO = 558,
    [Description("NOK - Norwegian krone")] NOK = 578,
    [Description("NPR - Nepalese rupee")] NPR = 524,

    [Description("NZD - New Zealand dollar")]
    NZD = 554,
    [Description("OMR - Omani rial")] OMR = 512,

    [Description("PAB - Panamanian balboa")]
    PAB = 590,
    [Description("PEN - Peruvian sol")] PEN = 604,

    [Description("PGK - Papua New Guinean kina")]
    PGK = 598,
    [Description("PHP - Philippine peso")] PHP = 608,
    [Description("PKR - Pakistani rupee")] PKR = 586,
    [Description("PLN - Polish złoty")] PLN = 985,

    [Description("PYG - Paraguayan guaraní")]
    PYG = 600,
    [Description("QAR - Qatari riyal")] QAR = 634,
    [Description("RON - Romanian leu")] RON = 946,
    [Description("RSD - Serbian dinar")] RSD = 941,
    [Description("CNY - Renminbi[14]")] CNY = 156,
    [Description("RUB - Russian ruble")] RUB = 643,
    [Description("RWF - Rwandan franc")] RWF = 646,
    [Description("SAR - Saudi riyal")] SAR = 682,

    [Description("SBD - Solomon Islands dollar")]
    SBD = 90,

    [Description("SCR - Seychelles rupee")]
    SCR = 690,
    [Description("SDG - Sudanese pound")] SDG = 938,

    [Description("SEK - Swedish krona (plural: kronor)")]
    SEK = 752,

    [Description("SGD - Singapore dollar")]
    SGD = 702,

    [Description("SHP - Saint Helena pound")]
    SHP = 654,

    [Description("SLL - Sierra Leonean leone")]
    SLL = 694,

    [Description("SLE - Sierra Leonean leone")]
    SLE = 925,
    [Description("SOS - Somali shilling")] SOS = 706,

    [Description("SRD - Surinamese dollar")]
    SRD = 968,

    [Description("SSP - South Sudanese pound")]
    SSP = 728,

    [Description("STN - São Tomé and Príncipe dobra")]
    STN = 930,

    [Description("SVC - Salvadoran colón")]
    SVC = 222,
    [Description("SYP - Syrian pound")] SYP = 760,
    [Description("SZL - Swazi lilangeni")] SZL = 748,
    [Description("THB - Thai baht")] THB = 764,

    [Description("TJS - Tajikistani somoni")]
    TJS = 972,

    [Description("TMT - Turkmenistan manat")]
    TMT = 934,
    [Description("TND - Tunisian dinar")] TND = 788,
    [Description("TOP - Tongan paʻanga")] TOP = 776,
    [Description("TRY - Turkish lira")] TRY = 949,

    [Description("TTD - Trinidad and Tobago dollar")]
    TTD = 780,

    [Description("TWD - New Taiwan dollar")]
    TWD = 901,

    [Description("TZS - Tanzanian shilling")]
    TZS = 834,

    [Description("UAH - Ukrainian hryvnia")]
    UAH = 980,

    [Description("UGX - Ugandan shilling")]
    UGX = 800,

    [Description("USD - United States dollar")]
    USD = 840,

    [Description("USN - United States dollar (next day) (funds code)")]
    USN = 997,

    [Description("UYI - Uruguay Peso en Unidades Indexadas (URUIURUI) (funds code)")]
    UYI = 940,
    [Description("UYU - Uruguayan peso")] UYU = 858,

    [Description("UYW - Unidad previsional")]
    UYW = 927,
    [Description("UZS - Uzbekistan som")] UZS = 860,

    [Description("VED - Venezuelan bolívar digital")]
    VED = 926,

    [Description("VES - Venezuelan bolívar soberano")]
    VES = 928,
    [Description("VND - Vietnamese đồng")] VND = 704,
    [Description("VUV - Vanuatu vatu")] VUV = 548,
    [Description("WST - Samoan tala")] WST = 882,
    [Description("XAF - CFA franc BEAC")] XAF = 950,

    [Description("XAG - Silver (one troy ounce)")]
    XAG = 961,

    [Description("XAU - Gold (one troy ounce)")]
    XAU = 959,

    [Description("XBA - European Composite Unit (EURCO) (bond market unit)")]
    XBA = 955,

    [Description("XBB - European Monetary Unit (E.M.U.-6) (bond market unit)")]
    XBB = 956,

    [Description("XBC - European Unit of Account 9 (E.U.A.-9) (bond market unit)")]
    XBC = 957,

    [Description("XBD - European Unit of Account 17 (E.U.A.-17) (bond market unit)")]
    XBD = 958,

    [Description("XCD - East Caribbean dollar")]
    XCD = 951,

    [Description("XDR - Special drawing rights")]
    XDR = 960,
    [Description("XOF - CFA franc BCEAO")] XOF = 952,

    [Description("XPD - Palladium (one troy ounce)")]
    XPD = 964,

    [Description("XPF - CFP franc (franc Pacifique)")]
    XPF = 953,

    [Description("XPT - Platinum (one troy ounce)")]
    XPT = 962,
    [Description("XSU - SUCRE")] XSU = 994,

    [Description("XTS - Code reserved for testing")]
    XTS = 963,

    [Description("XUA - ADB Unit of Account")]
    XUA = 965,
    [Description("XXX - No currency")] XXX = 999,
    [Description("YER - Yemeni rial")] YER = 886,

    [Description("ZAR - South African rand")]
    ZAR = 710,
    [Description("ZMW - Zambian kwacha")] ZMW = 967,

    [Description("ZWL - Zimbabwean dollar")]
    ZWL = 932
}