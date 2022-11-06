using MyConference.ViewModels;
using System.Collections;

namespace MyConference.Pages;

public partial class ComponentsPage : ContentPage
{

    ArrayList ArrayNBP = new ArrayList();

    bool LOADINGNOW, ERRORCHECK, CHECKINGDEWT, CHECKINGDEWTfound, CHECKINGBUBBLET, CHECKINGBUBBLETfound;
    bool sys1compostn_file1_open, sys1compostn_file2_open, sys2compostn_file1_open, sys2compostn_file2_open, sys3compostn_file1_open, sys3compostn_file2_open, DEWBUBIsCALCING;
    bool sys1dewbubT_file1_open, sys1dewbubT_file2_open, sys1dewT_file1_open, sys1dewT_file2_open, sys1bubT_file1_open, sys1bubT_file2_open;
    bool sys2dewbubT_file1_open, sys2dewbubT_file2_open, sys2dewT_file1_open, sys2dewT_file2_open, sys2bubT_file1_open, sys2bubT_file2_open;
    bool sys3dewbubT_file1_open, sys3dewbubT_file2_open, sys3dewT_file1_open, sys3dewT_file2_open, sys3bubT_file1_open, sys3bubT_file2_open;
    bool sys1dewbubP_file1_open, sys1dewbubP_file2_open, sys1dewP_file1_open, sys1dewP_file2_open, sys1bubP_file1_open, sys1bubP_file2_open;
    bool sys2dewbubP_file1_open, sys2dewbubP_file2_open, sys2dewP_file1_open, sys2dewP_file2_open, sys2bubP_file1_open, sys2bubP_file2_open;
    bool sys3dewbubP_file1_open, sys3dewbubP_file2_open, sys3dewP_file1_open, sys3dewP_file2_open, sys3bubP_file1_open, sys3bubP_file2_open;
    bool PHASEENVFLAG1, PHASEENVFLAG2, PHASEENVFLAG3, PHASEENVFLAG4, PHASEENVFLAG5, PHASEENVFLAG6, PHASEENVFLAG7, PHASEENVFLAG8, PHASEENVFLAG9;
    bool TimerBUBBLETEMP, TimerDEWTEMP, TimerBUBBLEPRES, TimerDEWPRES, TimerCOMPOSITION, DEWBUBT1CALCING, DEWBUBT2CALCING, DEWBUBT3CALCING;

        object NEWTOL, PLOTTY4, holdcompbinary, nFRAC2, BATCHTEMPHOLD, ysumtotalT, VtotalT, LiquidvalueT, Tfinal, newzisumT, BATCHOPPHOLD, BATCHOPPTHOLD;
        object[] boilingpttempselectedcomponent, boilingpttempfrmlselected, boilingptpresselectedcomponent, boilingptpresfrmlselected = new object[2];
        object[] McCabeThieleManualBfrmlselected, BinaryselectedcompMcCabeThieleAuto, BinaryselectedcompMcCabeThieleManual, BinaryselectedcompMcCabeThieleAutoIndexHolder, BinaryselectedcompMcCabeThieleManualIndexHolder = new object[3];
        object[] Binaryselectedcomponent, Bfrmlselected, MCcabeThManieleManualBfrmlselected, BinaryselectedcompMCcabeThManieleAuto, BinaryselectedcompMCcabeThManieleManual, BinaryselectedcompMCcabeThManieleAutoIndexHolder, BinaryselectedcompMCcabeThManieleManualIndexHolder = new object[3];
        object[] Ternaryselectedcomponent, Tfrmlselected = new object[4];
        object[] PastTempsForVCalc = new object[5];
        object[] BoilingptCompareComponents, BoilingPTCompareCompAliass, BoilingptfrmlCompareComponents, AZEXfrmlselected, AZEXselectedcomponent, COMPSPECIALHOLDER, Programgo = new object[11];
        object[] Ziholdold = new object[50];
        object[] COMPSNAMEHOLDER, COMPSFRMLHOLDER, BINPARNAMEHOLDER = new object[100];
        object[] WHOSEPLOTMultT1, WHOSEPLOTMultP1, WHOSEPLOTMultT2, WHOSEPLOTMultP2, WHOSEPLOTMultT3, WHOSEPLOTMultP3, WHOSEPLOTMULTSYS1XYZ, WHOSEPLOTSINGTEMPVOL, WHOSEPLOTSINGPRESVOL, WHOSEPLOTSINGTEMPVOLALLPRESCALC, WHOSEPLOTSINGPRESVOLALLTEMPCALC  = new object[100];
        object[] WHOSEPLOTSINGTEMPSYS1, WHOSEPLOTSINGPRESSYS1, WHOSEPLOTSINGTEMPSYS2, WHOSEPLOTSINGPRESSYS2, WHOSEPLOTSINGTEMPSYS3, WHOSEPLOTSINGPRESSYS3 = new object[100];
        object[] WHOSEPLOTBINTEMPSING, WHOSEPLOTBINPRESSING, WHOSEPLOTBINTEMPMULT, WHOSEPLOTBINPRESMULT, WHOSEPLOTPHASEENV, WHOSEPLOTSINGPTRANGE, WHOSEPLOTSINGPTRANGECOMPARE, WHOSEPLOTSINGPTRANGECOMPAREPHSENV   = new object[100];

        string SuperDBString1, SuperDBString2, fileName, fileName1, fileNameSaveas, PropertiesCompareToDel;
        string OPTOUTUNIT2, OPPOUTUNIT5, OPPOUTUNIT3, OPPOUTUNIT1, OPPOUTUNIT2, OPPOUTUNIT4, OPTOUTUNIT1, OPTOUTUNIT3;
        string[] YAXISSINGPTRANGE, XAXISSINGPTRANGE, XAXISSINGPTRANGECOMPARE, YAXISSINGPTRANGECOMPARE, XAXISSINGTEMPVOL, YAXISSINGTEMPVOL, XAXISSINGPRESVOL, YAXISSINGPRESVOL, XAXISSINGPTRANGECOMPAREPHSENV, YAXISSINGPTRANGECOMPAREPHSENV, Aselectedcomponent, SelectedcomponentAlias, Afrmlselected = new string[100];
 //       string[,] CURRDATAimportantPROPSString = new string[850, 5];
        string[,] CURRDATAallPROPSString = new string[850, 6];
        string[] PropertiesCompareComponents, PropertiesfrmlCompareComponents = new string[21];
        List<string> PropertiesCompareComponentss = new List<string>();
        Dictionary<string, Double> My_dict1 = new Dictionary<string, Double>();
        Dictionary<string, Double> My_dict2 = new Dictionary<string, Double>();
        Dictionary<string, Double> My_dict3 = new Dictionary<string, Double>();

        Int32 i, Counter1, Counter2, Counter3, feasibleflagxiyi, yixiselectedindex, YIXISELECTED, YIXISELECTED3, yixiselectedfracindex, dewbubblestopper, MAXTEMPVOLLIQVAPSPECVOL, MAXPRESVOLLIQVAPSPECVOL, UPDATETEMPVOLALLPRESCALCS;
        Int32 TOTALLCOMPSCOUNT, KCALC, CALCULATEDFLAG, YIORXIBATCHFLAG, BATCHrunFLAG, EOSTYPE, HOLDH2COMPNUM;

        Int32 SuperRow, MCcabeThManieleTurnONPlots, MCcabeThManIELEMINSTAGESholder, TABLECOUNTBINSINGTMcCabThieleMan, MCCABETHIELEUSEMANNOEQN, LASTBINCOMPSELECTED, LASTBINMCCABETHCOMPSELECTED, LASTTERCOMPSELECTED, SIMPDISTUPDATEDATA, ActivCoeffFirst, McCabeThieleTurnONPlots, McCABETHIELEMINSTAGESholder, HolderforStages, HolderforActualStages, CBXOrder, UPDATECURRDBPT;
        Int32 FRACCOL1BTMLVLONOFF, FRACCOL2BTMLVLONOFF, FLAGFORZICHANGE, XIYIFLAG, AZEOTEMPUSEFLAG, FRAC1STARTORCONT, FLAGSTARTORNOT, CHOOSESTARTORNOT, TIELINESYS1XYZFLAG;
        Int32 SYS1TDBUPDT, SYS1PDBUPDT, SYS2TDBUPDT, SYS2PDBUPDT, SYS3TDBUPDT, SYS3PDBUPDT, SYS1T1MULTDBUPDT, SYS1T2MULTDBUPDT, SYS1T3MULTDBUPDT, SYS1T4MULTDBUPDT, SYS1T5MULTDBUPDT;
        Int32 SYS2T1MULTDBUPDT, SYS2T2MULTDBUPDT, SYS2T3MULTDBUPDT, SYS2T4MULTDBUPDT, SYS2T5MULTDBUPDT, SYS3T1MULTDBUPDT, SYS3T2MULTDBUPDT, SYS3T3MULTDBUPDT, SYS3T4MULTDBUPDT, SYS3T5MULTDBUPDT;
        Int32 SYS1P1MULTDBUPDT, SYS1P2MULTDBUPDT, SYS1P3MULTDBUPDT, SYS1P4MULTDBUPDT, SYS1P5MULTDBUPDT;
        Int32 SYS2P1MULTDBUPDT, SYS2P2MULTDBUPDT, SYS2P3MULTDBUPDT, SYS2P4MULTDBUPDT, SYS2P5MULTDBUPDT, SYS3P1MULTDBUPDT, SYS3P2MULTDBUPDT, SYS3P3MULTDBUPDT, SYS3P4MULTDBUPDT, SYS3P5MULTDBUPDT;
        Int32 sys1T_mult1, sys1T_mult2, sys1T_mult3, sys1T_mult4, sys1T_mult5, sys1P_mult1, sys1P_mult2, sys1P_mult3, sys1P_mult4, sys1P_mult5, sys2T_mult1, sys2T_mult2, sys2T_mult3, sys2T_mult4, sys2T_mult5;
        Int32 sys2P_mult1, sys2P_mult2, sys2P_mult3, sys2P_mult4, sys2P_mult5, sys3T_mult1, sys3T_mult2, sys3T_mult3, sys3T_mult4, sys3T_mult5, sys3P_mult1, sys3P_mult2, sys3P_mult3, sys3P_mult4, sys3P_mult5;
        Int32 binT_file, binTmult_file, binP_file, binPhaseEnv_file, DEWBUBBLETREACHEDFLAG, DEWBUBTFLAG, TIELINETEMP1SINGFLAG, TIELINEPRES1SINGFLAG, TIELINETEMP2SINGFLAG, TIELINEPRES2SINGFLAG, TIELINETEMP3SINGFLAG, TIELINEPRES3SINGFLAG;
        Int32 binPmult1_file, binPmult2_file, binPmult3_file, binPmult4_file, binPmult5_file, binPmult_file, binTmult1_file, binTmult2_file, binTmult3_file, binTmult4_file, binTmult5_file, PlotOpCondPhsEnv_file1_open;
        Int32 TIELINETEMP1MULTFLAG, TIELINEPRES1MULTFLAG, TIELINETEMP2MULTFLAG, TIELINEPRES2MULTFLAG, TIELINETEMP3MULTFLAG, TIELINEPRES3MULTFLAG, BINTEMPSINGFLAG, BINPRESSINGFLAG, BINTEMPMULTFLAG, BINPRESMULTFLAG, BINPHASEENVFLAG;
        Int32 SINGPTRANGEFLAG, SINGPTRANGECOMPAREFLAG, SINGPTRANGECOMPAREPHSENVFLAG, KIJBINARY12TEXTUPDATE, KIJBINARY21TEXTUPDATE;
        Int32 APPLICATIONPAUSEDFLAG, BINPLOTSSINGXYTCOMP, BINPLOTSSINGXYTDIAGLINE, BINPLOTSSINGXYPCOMP, BINPLOTSSINGXYPDIAGLINE, BINPLOTSMULTXYTCOMP, BINPLOTSMULTXYTDIAGLINE, BINPLOTSMULTXYPCOMP, BINPLOTSMULTXYPDIAGLINE;
        Int32 xiyisys1Tindex, xiyisys2Tindex, xiyisys3Tindex, NUMBEROFCOLUMNS, FLAGFORTEMPVOLMASSMOLES,COL1TOCOL2, COL2TOCOL1, COL1TOCOL3, COL3TOCOL1, COL2TOCOL3, COL3TOCOL2;
        Int32 COL12LINKED, COL13LINKED, COL23LINKED, COL21LINKED, COL31LINKED, COL32LINKED, AZEXCOMPSELCOUNT, BINARYCOMPSELCOUNT, TERNARYCOMPSELCOUNT, ERRORNUMBER, MCOMPSTOUSE, COMPSELCOUNT, ONECOMPSELCOUNT, Summ, COL1ONGOING;
        Int32 SINGLECompFLAG, boilingptpresFLAG, boilingpttempFLAG, BINARYFLAG, RESULTROWCOUNT, GETBININTPARFLAG, FRACCOL1CONDONOFF, FRACCOL2CONDONOFF, FRACCOL1REBONOFF, FRACCOL2REBONOFF;
        Int32 BUBBLET1ONLYLFAG, BUBBLET2ONLYLFAG, BUBBLET3ONLYLFAG, BUBBLEP1ONLYLFAG, BUBBLEP2ONLYLFAG, BUBBLEP3ONLYLFAG;
        Int32 DEWT1ONLYLFAG, DEWT2ONLYLFAG, DEWT3ONLYLFAG, DEWP1ONLYLFAG, DEWP2ONLYLFAG, DEWP3ONLYLFAG, TABLECOUNTSINGRANGEPT;
        Int32 RUNNINGFLAG, FLAGSETCOMPCALCT, FLAGSETCOMPCALCP, GLOBALSTOPFLAG, PRINTKANDRELVELFLAG, SPVOLDENPRESFLAG, SPVOLDENFLAG, SINGTEMPVOLFLAG, SINGPRESVOLFLAG, SINGTEMPVOLALLPRESCALCFLAG, SINGPRESVOLALLTEMPCALCFLAG;
        Int32 PRESCHECKONLY, VIEWCALCUL,  COMPONENTINUM1TEXCESS, TABLECOUNTSYS1SINGT, TABLECOUNTSYS2SINGT, TABLECOUNTSYS3SINGT, TABLECOUNTSYS1SINGP, TABLECOUNTSYS2SINGP, TABLECOUNTSYS3SINGP;
        Int32 TABLECOUNTSYS1MULTT1, TABLECOUNTSYS2MULTT1, TABLECOUNTSYS3MULTT1, TABLECOUNTSYS1MULTP1, TABLECOUNTSYS2MULTP1, TABLECOUNTSYS3MULTP1;
        Int32 TABLECOUNTSYS1MULTT2, TABLECOUNTSYS2MULTT2, TABLECOUNTSYS3MULTT2, TABLECOUNTSYS1MULTP2, TABLECOUNTSYS2MULTP2, TABLECOUNTSYS3MULTP2;
        Int32 TABLECOUNTSYS1MULTT3, TABLECOUNTSYS2MULTT3, TABLECOUNTSYS3MULTT3, TABLECOUNTSYS1MULTP3, TABLECOUNTSYS2MULTP3, TABLECOUNTSYS3MULTP3;
        Int32 TABLECOUNTSYS1MULTT4, TABLECOUNTSYS2MULTT4, TABLECOUNTSYS3MULTT4, TABLECOUNTSYS1MULTP4, TABLECOUNTSYS2MULTP4, TABLECOUNTSYS3MULTP4;
        Int32 TABLECOUNTSYS1MULTT5, TABLECOUNTSYS2MULTT5, TABLECOUNTSYS3MULTT5, TABLECOUNTSYS1MULTP5, TABLECOUNTSYS2MULTP5, TABLECOUNTSYS3MULTP5;
        Int32 TABLECOUNTBINSINGT, TABLECOUNTBINMULTT1, TABLECOUNTBINMULTT2, TABLECOUNTBINMULTT3, TABLECOUNTBINMULTT4, TABLECOUNTBINMULTT5;
        Int32 TABLECOUNTBINSINGP, TABLECOUNTBINMULTP1, TABLECOUNTBINMULTP2, TABLECOUNTBINMULTP3, TABLECOUNTBINMULTP4, TABLECOUNTBINMULTP5;
        Int32 TABLECOUNTBINPHASEENV1, TABLECOUNTBINPHASEENV2, TABLECOUNTBINPHASEENV3, TABLECOUNTBINPHASEENV4, TABLECOUNTBINPHASEENV5, TABLECOUNTBINPHASEENV6, TABLECOUNTBINPHASEENV7, TABLECOUNTBINPHASEENV8, TABLECOUNTBINPHASEENV9;
        Int32 CNTRL2FLAG2, cntrl2tray2, CNTRLFLAG2, cntrltray2, COMPSELCOUNTHOLDER, cntrltray1, CNTRLFLAG1, cntrl2tray1, CNTRL2FLAG1, fraciter;
        Int32 OPPTIEMULTCALCFLAG, diffcount, TIEMULTCALCFLAG, SEARCHCOUNTER, SEARCHCOUNT, OPTTIEMULTCALCFLAG, FLAGPLOTINGSYS1, FLAGPLOTINGSYS2, FLAGPLOTINGSYS3;
        Int32[] TABLECOUNTSINGRANGECOMPAREPT = new Int32[10];
        Int32[] PREFERENCES= new Int32[50];
        Int32[] TABLECOUNTSINGTEMPVOL, TABLECOUNTSINGPRESVOL, TABLECOUNTSINGTEMPVOLALLPRESCALC, TABLECOUNTSINGPRESVOLALLTEMPCALC, BINPARSAMEHOLD, TABLECOUNTSINGRANGECOMPAREPHSENVPT = new Int32[100];

        Int32 initialvaluecount, presxiyitol, tmrcount, TIMEFREQUENCY, TMRCOMPARE, TMRCOMPARE2, DivisionFactor;


        Double gLINEStarty, gLINEStartx, gLINEEndy, gLINEEndx, gBottomLINEEndy, gBottomLINEEndx, gLineSlope, yMcThManual, MCCABETHIELEBINAutoManualSelected, gLine2StepEndx, gLine2STepSizex, gLine3StepEndx, gLine3STepSizex;
        Double gLINE2Starty, gLINE2Startx, gLINE2Endy, gLINE2Endx, gLine2Slope, gLINE3Starty, gLINE3Startx, gLINE3Endy, gLINE3Endx, gLine3Slope, McCabeThieleRRAfterFeed2MinSlope, McCabeThieleRRAfterFeed3MinSlope;
        Double ActualLINEStarty, ActualLINEStartx, ActualLINEEndy, ActualLINEEndx, ActualBottomLINEEndy, ActualBottomLINEEnd, McCabeThieleREFLUXAMOUNT1, McCabeThieleREFLUXAMOUNT2, McCabeThieleREFLUXAMOUNT3;
        Double FeedgIntersectiony, FeedgIntersectionx, gBottomLINESlope, McCabeThieleRRSlope, McCabeThieleMingSlope, McCabeThieleDISTILLATEAMOUNT1, McCabeThieleDISTILLATEAMOUNT2, McCabeThieleDISTILLATEAMOUNT3, McCabeThieleBTTMPRODAMOUNT1, McCabeThieleBTTMPRODAMOUNT2, McCabeThieleBTTMPRODAMOUNT3, McCabeThieleDISTILLATEAMOUNTTOT, McCabeThieleBTTMPRODAMOUNTTOT, McCabeThieleREFLUXAMOUNTTOT, McCabeThieleFEEDAMOUNTTOT;
        Double FeedgIntersectiony2, FeedgIntersectionx2, McCabeThieleMINREFLUXAMOUNT, McCabeThieleREFLUXAMOUNTAFTERSD1, McCabeThieleREFLUXAMOUNTAFTERSD2, McCabeThieleREFLUXAMOUNTAFTERSD3, Tolerance, BUBBLETOLDHOLDER, LASTGOODBOILINGPTT, CAPTURDDEWTEMP, BOILINGPTCOMPARECOMPCOUNT, PROPERTIESCOMPARECOMPCOUNT;
        Double McCabeThieleREFLUXAMOUNTAFTERFEED1, McCabeThieleREFLUXAMOUNTAFTERFEED2, McCabeThieleREFLUXAMOUNTAFTERFEED3, McCabeThieleRRAfterFeed2, McCabeThieleRRAfterFeed3, McCabeThMinRefluxAmoun1, McCabeThMinRefluxAmount2, McCabeThMinRefluxAmount3;
        Double McCabeThieleRRAfterSD1, McCabeThieleRRAfterSD1Slope, McCabeThieleRRAfterSD2, McCabeThieleRRAfterSD2Slope, McCabeThieleRRAfterSD3, McCabeThieleRRAfterSD3Slope, McCabeThieleRRAfterFeed1, McCabeThieleRRAfterFeed1Slope, McCabeThieleRRAfterFeed2Slope, McCabeThieleRRAfterFeed3Slope;
        Double McCabeThieleStartvalueForx3, McCabeThieleStartvalueFory3, McCabeThieleStartvalueForx5, McCabeThieleStartvalueFory5, FeedgIntersectiony3, FeedgIntersectionx3, FeedgIntersectiony4, FeedgIntersectionx4, FeedgIntersectiony5, FeedgIntersectionx5, FeedgIntersectiony6, FeedgIntersectionx6;
        Double MCcabeThManIELEBINAutoManualSelected, DesignDistConstA, DesignDistConstB, MCcabeThManieleRRAfterFeed2MinSlope, MCcabeThManieleRRAfterFeed3MinSlope, MCcabeThManieleREFLUXAMOUNT1, MCcabeThManieleREFLUXAMOUNT2, MCcabeThManieleREFLUXAMOUNT3;
        Double MCcabeThManieleRRSlope, MCcabeThManieleMingSlope, MCcabeThManieleDISTILLATEAMOUNT1, MCcabeThManieleDISTILLATEAMOUNT2, MCcabeThManieleDISTILLATEAMOUNT3, MCcabeThManieleBTTMPRODAMOUNT1, MCcabeThManieleBTTMPRODAMOUNT2, MCcabeThManieleBTTMPRODAMOUNT3, MCcabeThManieleDISTILLATEAMOUNTTOT, MCcabeThManieleBTTMPRODAMOUNTTOT, MCcabeThManieleREFLUXAMOUNTTOT, MCcabeThManieleFEEDAMOUNTTOT;
        Double MCcabeThManieleMINREFLUXAMOUNT, MCcabeThManieleREFLUXAMOUNTAFTERSD1, MCcabeThManieleREFLUXAMOUNTAFTERSD2, MCcabeThManieleREFLUXAMOUNTAFTERSD3;
        Double MCcabeThManieleREFLUXAMOUNTAFTERFEED1, MCcabeThManieleREFLUXAMOUNTAFTERFEED2, MCcabeThManieleREFLUXAMOUNTAFTERFEED3, MCcabeThManieleRRAfterFeed2, MCcabeThManieleRRAfterFeed3, MCcabeThManMinRefluxAmoun1, MCcabeThManMinRefluxAmount2, MCcabeThManMinRefluxAmount3;
        Double MCcabeThManieleRRAfterSD1, MCcabeThManieleRRAfterSD1Slope, MCcabeThManieleRRAfterSD2, MCcabeThManieleRRAfterSD2Slope, MCcabeThManieleRRAfterSD3, MCcabeThManieleRRAfterSD3Slope, MCcabeThManieleRRAfterFeed1, MCcabeThManieleRRAfterFeed1Slope, MCcabeThManieleRRAfterFeed2Slope, MCcabeThManieleRRAfterFeed3Slope;
        Double MCcabeThManieleStartvalueForx3, MCcabeThManieleStartvalueFory3, MCcabeThManieleStartvalueForx5, MCcabeThManieleStartvalueFory5, FeedgIntersectiony2prime, FeedgIntersectiony4prime, FeedgIntersectiony6prime, VHOLDDistDesign, OPTHOLDDistDesign, OPPHOLDDistDesign;
        Double PLOTSTEPSIZE3, PLOTSTEPSIZE1, STEPMITIGATION, DERFUNC, YOM, DEWP, P, BUBBLEP, POK, t, OVERALLSPEED, COMBINEDOVERALLSPEED, PLOTSIZEDIFF, PLOTSTEPSIZE2, PLOTSTEPSIZE4, CHECKINGDEWTValue, CHECKINGDEWTValueV, CHECKINGBUBBLETValue, CHECKINGBUBBLETValueV;
        Double PREVIOUSBUBBLEP, PREVIOUSBUBBLET, Vnew, FUNC, SUMKX, DIFF, SUMKIXI, V, EPS, PREVIOUSDEWT, PREVIOUSDEWP, PATM, FL, FV_Renamed, PI, BUBBLEPSYS1KEEP, DEWPSYS1KEEP, BUBBLEPSYS2KEEP, DEWPSYS2KEEP, BUBBLEPSYS3KEEP, DEWPSYS3KEEP;
        Double FRACCOL1BTMLVLCTRL, FRACCOL1DELTAP, FRI, ELS, PLAIT, BUBBLET, DEWT, TOK, TLAIT, TLAIT2, TLAIT3, FRII, PLOTDELTADD, FRACCOL2DELTAP, FRACCOL2BTMLVLCTRL, BUBBLETSYS1KEEP, DEWTSYS1KEEP, BUBBLETSYS2KEEP, DEWTSYS2KEEP, BUBBLETSYS3KEEP, DEWTSYS3KEEP;
        Double FRACCOL2BTMLVLERROR, FRACCOL1BTMLVLERROR, FRACCOL1BTMLVLERROROLD, FRACCOL2BTMLVLERROROLD, ANOTHERMULTIPLIER, FRACCOL1TOTALALL, NmUpDownAccelrtr, MINTEMPVOLTEMPHOLDER, MAXTEMPVOLTEMPHOLDER, BPSINGCALCT, BPSINGCALCP;
        Double ROM, RAI, BETA, ZL, ZV, Zmiddle, ALPHA, GAMMA, SOM, Zissum, Z2, DELTA, QUIK, PPET, WRON1, WRON2, QQET, PICK, Z1, Z3, TASHOLDER, LIQFROM1, VAPFROM1;
        Double DADA, KIM1, LIM1, TIM1, TIM2, LIM2, DODO, STARTV, DEWBUBBLETREACHED, SPCVOLFOR1CALC, SPCVOLFORRNGCALC1, SPCVOLFORRNGCALC2, SPCVOLPRESFOR1CALC, SPCVOLPRESFORRNGCALC1, SPCVOLPRESFORRNGCALC2, SPCVOLPRESCALCTD, SPCVOLCALCTD, OPPPrevious, OPTPrevious;
        Double xiyisys1desyiTvalue, xiyisys1desxiTvalue, xiyisys1Vtemp, xiyisys1maxT, xiyisys1minP, XIYISYS1XITVALUE, XIYISYS1YITVALUE, XIYISYS1YITVALUEinitial, XIYISYS1YITVALUEhold, XIYISYS1XITVALUEinitial, XIYISYS1XITVALUEhold, XIYISYS1TEMPHOLD, XIYISYS1PRESHOLD;
        Double xiyisys2desyiTvalue, xiyisys2desxiTvalue, xiyisys2Vtemp, xiyisys2maxT, xiyisys2minP, XIYISYS2XITVALUE, XIYISYS2YITVALUE, XIYISYS2YITVALUEinitial, XIYISYS2YITVALUEhold, XIYISYS2XITVALUEinitial, XIYISYS2XITVALUEhold, XIYISYS2TEMPHOLD, XIYISYS2PRESHOLD;
        Double xiyisys3desyiTvalue, xiyisys3desxiTvalue, xiyisys3Vtemp, xiyisys3maxT, xiyisys3minP, XIYISYS3XITVALUE, XIYISYS3YITVALUE, XIYISYS3YITVALUEinitial, XIYISYS3YITVALUEhold, XIYISYS3XITVALUEinitial, XIYISYS3XITVALUEhold, XIYISYS3TEMPHOLD, XIYISYS3PRESHOLD;
        Double VVAP1HOLD, OPTLIQ1HOLD, OPTLIQ1, OPTVAP1HOLD, OPTVAP1, OPPVAP1, OPPVAP1HOLD, OPPLIQ1, OPPLIQ1HOLD, VLIQ1HOLD, POWERADDITION, deltaerrorholder, deltaerrorholder2, reboilertempholder, reboilertempholder2;
        Double VVAP1, OPT1, OPP1, V1, VLIQD1, Zissumsimpdist1, Zissumsimpdist12, Zissumsimpdist13, Zissumsimpdist2, Zissumsimpdist22, Zissumsimpdist23, Zissumsimpdist3, Zissumsimpdist4, Zissumsimpdist42, Zissumsimpdist43, Zissumsimpdist5, Zissumsimpdist52, Zissumsimpdist53;
        Double OPP1HOLD, OPT1HOLD, V1HOLD, FRACCOL1OVRLEFF, OPT1HOLDSIMPDISTSYS1, OPP1HOLDSIMPDISTSYS1, V1HOLDSIMPDISTSYS1, OPT1HOLDSIMPDISTSYS2, OPP1HOLDSIMPDISTSYS2, V1HOLDSIMPDISTSYS2, OPT1HOLDSIMPDISTSYS3, OPP1HOLDSIMPDISTSYS3, V1HOLDSIMPDISTSYS3, ZissumHOLD, Zissum2HOLD, Zissum3HOLD;
        Double Steploopvaltemp, Minloopvaltemp, Maxloopvaltemp, TMRMULT, TMRMULT2, FINPREVIOUS, FINERRORCHECK, FINCOUNTER, PRESSMINHOLDER, OMEGAa, OMEGAb, OMEGAc, YCS;
        Double R, Maxloopvalpres, STEPLOOPVAL, MINLOOPVAL, MAXLOOPVAL, Minloopvalpres, Steploopvalpres, XIYIYITVALUE, XIYIXITVALUE, XIYIYIPVALUE, XIYIXIPVALUE, TOUTPUT4, TOUTPUT2, TOUTPUT1, TOUTPUT3, TOUTPUT5;
        Double flgadddewp, flgchkdewp, flgchkdewt, flgchkbubblet, flgchkbubblep, flgadddewt, MULTPRESTEMPHOLDERLOW, keeplastdewp, MULTPRESTEMPHOLDERHIGH, VSTARTVALUEKEEPER, prerampmidpoint, initialvaluechange, temrampmidpoint, vaprampmidpoint;
        Double OPPOUTPUT, POUTPUT4, POUTPUT2, POUTPUT1, POUTPUT3, POUTPUT5, MaxIterationsPRESS, MaxIterations, xiyivalueat0, yixiselectedvalue, yixiselectedfracvalue, xiyivalueat1;
        Double BatchyiTindex, BatchmaxT, Batchtempstep, BatchyiTvalue, BatchVtemp, BatchyiPindex, BatchminP, Batchpresstep, BatchyiPvalue, BatchVpres, TOTALSIDE2DRAW, azex2ZIholdertotal;
        Double ysumtotalP, VtotalP, LiquidvalueP, Pfinal, LiquidT, LiquidP, newZissumT, xsumtotalT, yflowsumtotalT, BATCHPRESHOLD, newzisumP, BATCHOPTHOLD, newZissumP, xsumtotalP, yflowsumtotalP;


        Double[] PTSFORROTPIESYS1, PTSFORROTPIESYS2, PTSFORROTPIESYS3, ZETAc, EFCN = new double[100];

        Double[] ALPHATOWRITE, SMALLaTOWRITE, SMALLbTOWRITE, SMALLcTOWRITE, BIGATOWRITE, BIGBTOWRITE = new double[3];
        Double[] BINARYNBPHolder, BINARYNSGHolder, LocalPressureHolder, TERNARYNBPHolder, TERNARYNSGHolder,  RECYCFLAGSTG = new double[3];
        Double[] draw2stgliq, draw2stg, prcntdraw2stg, recyclein2stg, recycleout2stg, prcntrecycle2stg,recycin2stgliq, recycin2stg, recycin2temp, recycout2stgliq, recycout2stg, prcntrecyc2stg, recycout2temp  = new double[5];
        Double[] PresLocalHolder, TempLocalHolder, FINHOLDER= new double[18];
        Double[] RECYCLEIN2XI,  SIDEdraw2XI, RECYCLEOUT2XI,  recyin2xiholder  = new double[599];

        Double[] ZIHOLDDistDesign, VAPRDistDesign, LIQDDistDesign, azexZI, FRACCOL1PRIORTEMP, FRACCOL2PRIORTEMP, FRACCOL3PRIORTEMP = new double[100];
        Double[,] K = new double[100, 100];
//        Double[,] CURRDATAimportantPROPSDouble = new double[850, 102];
        Double[,] CURRDATAallPROPSDouble = new double[850, 680];
        Double[,] CURRDATAXY, CURRDATAPT = new double[1010, 850];

        Double[,] CURRDATABINTXY, CURRDATABINPXY, CURRDATABINPHASEENV1, CURRDATABINPHASEENV2, CURRDATABINPHASEENV3, CURRDATABINPHASEENV4, CURRDATABINPHASEENV, CURRDATABINPHASEENV6, CURRDATABINPHASEENV7, CURRDATABINPHASEENV8, CURRDATABINPHASEENV9, CURRDATABINPHASEENV10 = new double[310, 150];
        Double[,] CURRDATABINMULTT1, CURRDATABINMULTT2, CURRDATABINMULTT3, CURRDATABINMULTT4, CURRDATABINMULTT5, CURRDATABINMULTP1, CURRDATABINMULTP2, CURRDATABINMULTP3, CURRDATABINMULTP4, CURRDATABINMULTP5 = new double[310, 150];
        Double[,] CURRDATAALLSYSTEM1T, CURRDATAALLSYSTEM1P, CURRDATAALLSYSTEM2T, CURRDATAALLSYSTEM2P, CURRDATAALLSYSTEM3T, CURRDATAALLSYSTEM3P, CURRDATAONEFORALL = new double[310, 150];
        Double[,] CURRDATABoilPointPTRange = new double[3010, 150];
        Double[,,] CURRDATABoilPointPTRangeCompare = new double[11, 3010, 25];
        Double[,,] CURRDATABoilPointPTRANGECOMPAREPhsEnv = new double[100, 3010, 50]; 
        Double[,,] CURRDATASINGTEMPVOL, CURRDATASINGPRESVOL, CURRDATASINGTEMPVOLALLPRESCALC = new double[50, 1010, 300]; 
        Double[,,] CURRDATASINGPRESVOLALLTEMPCALC = new double[20, 1010, 300];

        Double[] PR, FIV, FIL, D, AX, GX, PL, QIV, QIL, KMIN, NEWK, API, TBP, TC, PC = new double[100];
        Double[] KW, TCC, PCC, PCCPascal, TBB, TBR, KAPPA, AS1, AS2, BS, CS, TB, AST, NBP, YIBUBT, YIBUBP, XIDEWT, XIDEWP = new double[100];
        Double[] SG, YI, XI, ZI, PRI, KII, KIXI, KIYI, Y, LOP, LIP, LETT, TELL, FUN, DERFUN, SGCalc, COMPNumberOfCarbons = new double[100];
        Double[] VAPR1, VAPR1HOLD, VAPR1VAPR2, VAPR1LIQD2, LIQD1, LIQD1HOLD, LIQD1VAPR2, LIQD1LIQD2, VAPR1xiyi, LIQD1xiyi, VAPR1xiyifrac, LIQD1xiyifrac  = new double[100];
        Double[] CCOMPNumberOfCarbons, COMPMoleWt, COMPNormalBPtdegF, COMPNormalBPtRankin, COMPReducedBPt, COMPNormalFreezPt, COMPReducedFreezPt, COMPCriticalTempdegF, COMPCriticalTempRankin = new double[100];
        Double[] COMPCriticalPres, COMPCriticalVol, COMPCriticalCompFctr, COMPAccentricFctr, COMPAccentricFctrCalc, COMPSpecGrav, COMPCalcLiqMolVol60degF, COMPAPIGravity60degF, COMPLiqDensity60degF, COMPRefracIndex77degF = new double[100];
        Double[] COMPVaporPres100degF, COMPVaporPresCalc100degF, COMPVaporPresDeviat100degF, COMPIdealGasCp60degF, COMPLiquidCp60degF, COMPLiqKinemVisc100, COMPLiqKinemVisc210, COMPHeatofVaprzn, COMPLiqHeatofComb77degFBTUperlb = new double[100];
        Double[] COMPLiqHeatofComb77degFBTUpergal, COMPLiqSurfTension77degF, COMPSolubParam, COMPFlashPt, COMPIdelGasHeatofForm, COMPIdelGasGibbsFEnrgForm, COMPHeatofFusion, COMPLiqCoeffExpn60degF, COMPAnilinePt, COMPOctaneNumMotorClear = new double[100];
        Double[] COMPOctaneNumMotp3TELpergal, COMPOctaneNumResearchClear, COMPOctaneNumResp3TELpergal, COMPLowerFlammLim, COMPUpperFlammLim, COMPWatsonKFactor, COMPDipoleMoment, COMPVapHeatCapA, COMPVapHeatCapB, COMPVapHeatCapC, COMPVapHeatCapD = new double[100];
        Double[] COMPLiqViscB, COMPLiqViscC, COMPStdHeatForm, COMPStdEnergy, COMPAntVapPresA, COMPAntVapPresB, COMPAntVapPresC, COMPAntVapPresMaxT, COMPAntVapPresMinT, COMPHarlVapPresA, COMPHarlVapPresB, COMPHarlVapPresC, COMPHarlVapPresD, COMPHeatVaporNBP = new double[100];
        Double[] ZI1, FRACCOL1VAPSTAY, FRACCOL1LIQSTAY, FRACCOL2VAPSTAY, FRACCOL2LIQSTAY, FRACCOL3VAPSTAY, FRACCOL3LIQSTAY = new double[100];
        Double[] ZI1HOLDSIMPDISTSYS1, VAPR1SIMPDISTSYS1, LIQD1SIMPDISTSYS1, LIQD1KEEPSIMPDISTSYS1 = new double[100];
        Double[] ZI1HOLDSIMPDISTSYS2, VAPR1SIMPDISTSYS2, LIQD1SIMPDISTSYS2, LIQD1KEEPSIMPDISTSYS2 = new double[100];
        Double[] ZI1HOLDSIMPDISTSYS3, VAPR1SIMPDISTSYS3, LIQD1SIMPDISTSYS3, LIQD1KEEPSIMPDISTSYS3 = new double[100];
        Double[] ZI1HOLD, ZIVAP1HOLD, ZILIQ1HOLD, TOLDSFORVCALC, VOLDSFORVCALC, azex2ZIholder, azex2tempval, azex2stgval, azex2tempholder = new double[100];
        Double[] yissumT, BATCHZIHOLDT,  xissumT, yiallsumT, yiallflowsumT, yiflowsumT, yflowsumfinalT = new double[100];
        Double[] yissumP, BATCHZIHOLDP, xissumP, yiallsumP, yiallflowsumP, yiflowsumP, yflowsumfinalP = new double[100];
        Double[] TempHolderForExpandedVolume, LiqExpandedVolumeHolderTemp, ExpandedVolumeHolderTemp, PresHolderForExpandedVolume, LiqExpandedVolumeHolderPres, ExpandedVolumeHolderPres = new double[1010];



    int MyCounter = 0;
	public ComponentsPage()
	{
		InitializeComponent();
	}

    private async void OnCounter_Clicked(object sender, EventArgs e)
    {
        MyCounter++;
        if (MyCounter==1)
            await Shell.Current.GoToAsync("//VLEFlash1Page");
        else if (MyCounter == 2)
            await Shell.Current.GoToAsync("//VLEFlash2Page");
        else
            await Shell.Current.GoToAsync("//VLEFlash3Page");

        if (MyCounter == 3)
            MyCounter = 0;
        OnCounter.Text= MyCounter.ToString();

    }
}