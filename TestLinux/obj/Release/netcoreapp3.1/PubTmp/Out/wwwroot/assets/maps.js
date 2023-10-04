/**
 * @license
 * Copyright 2019 Google LLC. All Rights Reserved.
 * SPDX-License-Identifier: Apache-2.0
 */
// The following example creates complex markers to indicate beaches near
// Sydney, NSW, Australia. Note that the anchor is set to (0,32) to correspond
// to the base of the flagpole.
function initMap() {
    console.log('Hello');
  const map = new google.maps.Map(document.getElementById("map"), {
    zoom: 7,
    center: { lat: 21.2787, lng: 81.8661 },
  });

  //const ctaLayer = new google.maps.KmlLayer({
  //  url: "/assets/India-States.kml",
  //  map: map,
  //});

  setMarkers(map);

  
}

// Data for the markers consisting of a name, a LatLng and a zIndex for the
// order in which these markers should display on top of each other.
const beaches = [
    ["101-ABHANPUR",21.052778,81.745556],
    ["102-PALARI",21.538901,82.168695],
    ["103-AMLIPADAR",21.191226,83.16758],
    ["104-ARANG",21.194994,81.965346],
    ["105-ARJUNI",21.460897,82.277339],
    ["106-BALODA BAZAR",21.656981,82.156335],
    ["107-BASIN",20.991561,81.988932],
    ["108-BHANPURI",21.293513,81.651077],
    ["109-BHATAPARA",21.73837,81.948026],
    ["110-BHATGAON",21.657753,82.803461],
    ["111-CHAMPARAN",21.034692,81.924421],
    ["112-CHHURA",20.810803,82.208065],
    ["113-DEOBHOG",19.900836,82.655096],
    ["114-DONDEKALA",21.322939,81.7733],
    ["115-FINGESHWER",20.97302,82.035265],
    ["116-GARIYABAND",20.633333,82.066667],
    ["117-GIDHOURI",21.656917,82.159196],
    ["118-HATHBAND",21.630123,81.852488],
    ["119-HEERAPUR",21.242072,81.617324],
    ["120-KASDOL",21.627548,82.423812],
    ["121-KATGI",21.660167,82.522642],
    ["122-LAWAN",21.642885,82.338407],
    ["123-LIMTARA",21.757622,81.797839],
    ["124-MAINPUR",20.644998,82.174083],
    ["125-MANA",21.187748,81.703634],
    ["126-MANDIR HASOUD",21.188553,81.958694],
    ["128-PANDITARAI",21.253099,81.64876],
    ["129-PANDUKA",20.793966,81.939842],
    ["130-PAWANI",21.666441,82.696941],
    ["131-RAJIM",20.861882,82.196157],
    ["132-SANDI",21.455602,82.069314],
    ["133-SARAGAON",21.369256,81.807182],
    ["134-SARSIWA",21.630575,82.929988],
    ["135-SILYARI",21.251384,81.629641],
    ["136-TARPONGI",21.494152,81.690472],
    ["137-TILDA",21.551312,81.797118],
    ["138-RAIPUR (SU. NAGAR)",21.23262,81.606188],
    ["139-RAIPUR P BASTI",21.232132,81.626113],
    ["140-RAIPUR SANTOSHI NAGAR",21.215159,81.640821],
    ["141-Shanker Nagar Raipur",21.252939,81.672792],
    ["142-TELIBANDHA",21.239207,81.663383],
    ["143-Saddu Raipur",21.276136,81.700602],
    ["144-BIRGAON",21.306586,81.619547],
    ["145-DHARSIWA",21.408186,81.671991],
    ["146-KHARORA",21.405842,81.9262],
    ["147-SEJBAHAR",21.172002,81.667728],
    ["148-SIMGA",21.63,81.7],
    ["149-BILAIGARH",21.640836,82.721226],
    ["150-SUHELA",21.618738,81.983479],
    ["151-FAFADIH",21.266257,81.643235],
    ["152-JAISTAMBH CHOWK",21.240716,81.630522],
    ["153-GUDIYARI RAIPUR",21.263733,81.629786],
    ["154-KABIR NAGAR",21.266758,81.593913],
    ["155-SONAKHAN",21.511826,82.551047],
    ["156-TUNDRA",21.677314,82.607821],
    ["157-Amlidih",21.22102,81.6749],
    ["158-Kolar",21.083089,81.677467],
    ["159-Karhibazar",21.656917,82.159196],
    ["160-KOPRA",20.840532,81.923471],
    ["162-Daldalseoni",21.287586,81.685681],
    ["163-Lahod",21.649917,82.266477],
    ["201-BAGHBAHARA",21.068519,82.292951],
    ["202-BASNA",21.28,82.82],
    ["203-BHANWERPUR",21.368565,82.903087],
    ["204-DEORI",21.443202,82.649503],
    ["205-JAGDISHPUR",21.336381,82.773814],
    ["206-JHALAP",21.217086,82.385867],
    ["207-KOMAKHAN",20.967554,82.468506],
    ["208-MAHASAMUD",21.109132,82.097902],
    ["209-PATEWA",21.218327,82.28277],
    ["210-SANKARA",21.284487,82.666995],
    ["211-SARAIPALI",21.109132,82.097902],
    ["212-SINGHORA",21.298197,83.172939],
    ["213-SIRPUR",21.346829,82.185341],
    ["214-TENDUKONA",21.11185,82.466475],
    ["215-Tumgaon",21.187449,82.130655],
    ["216-BIRKONI",21.18126,82.051842],
    ["217-PITHORA",21.254121,82.518868],
    ["301-BELARGAON",20.280671,81.841562],
    ["302-DARBA",20.979258,81.716473],
    ["303-DHAMTARI",20.712085,81.549548],
    ["304-DOMA",20.774934,81.635017],
    ["305-DUGLI",20.486354,81.877067],
    ["306-KARELI",20.857224,81.83883],
    ["307-MAROUD",20.901927,81.685758],
    ["308-NAGARI",20.347659,81.959515],
    ["309-RATNABANDA",20.71,81.55],
    ["310-SANKARA (N)",20.783851,81.839628],
    ["311-SIRRI",20.936982,81.75163],
    ["312-TARSIVA",20.79301,81.551415],
    ["313-BHAKHARA",20.894421,81.599395],
    ["314-KURUD",20.83,81.72],
    ["315-MEGHA",20.772837,81.806039],
    ["316-AMDI",20.772233,81.491498],
    ["317-MAGARLOAD",20.774999,81.827305],
    ["318-CHHATI",20.779491,81.667884],
    ["319-ARJUNI",20.404075,81.762295],
    ["321-Mohandi",21.01906,81.704385],
    ["401-Beltara",22.079625,82.139141],
    ["402-Bilaspur",22.073204,82.156176],
    ["403-Bilha",21.957446,82.075159],
    ["404-Chakarbhata",22.007394,82.105144],
    ["405-Ganiyari",22.258711,81.867526],
    ["406-Khamhi",22.07,81.68],
    ["407-Jarhabhata",22.080012,82.142195],
    ["408-Jairam Nagar",22.034,82.296],
    ["409-Jondhara",21.993155,82.265121],
    ["410-Kanteli",22.07,81.68],
    ["411-Kargikala",22.254791,81.918013],
    ["412-Khamhariya",21.70088,82.406977],
    ["413-Khongsara",22.552201,81.933703],
    ["414-Kotmi",22.813833,82.092458],
    ["415-Marwahi",23.008,82.070675],
    ["416-Masturi",21.991389,82.267778],
    ["417-Mungeli",22.066513,81.678275],
    ["418-Pathariya",22.015537,81.837464],
    ["419-Pendra",22.77743,81.956209],
    ["420-Pendra Road",22.891494,81.884173],
    ["421-Sakri",22.111756,82.078845],
    ["422-Sargaon",22.07,81.68],
    ["423-Seepat",22.156671,82.274624],
    ["424-Setganga",22.117559,81.54593],
    ["425-Takhatpur",22.137692,81.869816],
    ["426-Mungelinaka",22.087873,82.133709],
    ["427-Sarkanda",22.100241,82.146885],
    ["428-Bodri",22.080913,82.184976],
    ["429-Lingiyadih",22.018659,82.097222],
    ["430-Ratanpur",22.2869,82.163102],
    ["431-Kota",22.297709,82.02658],
    ["432-Lormi",22.275379,81.701756],
    ["433-Belgahana",22.432317,82.033848],
    ["434-NAGPURA",22.041771,82.152918],
    ["435-TIFRA",22.063931,82.130561],
    ["436-TORWA",22.079625,82.139141],
    ["437-VYAPAR VIHAR",22.06613,82.145524],
    ["438-GANDHI CHOWK",22.079625,82.139141],
    ["439-Koni",22.128611,82.133889],
    ["440-Deorikhurd",22.060172,82.198891],
    ["441-Mangla",22.092022,82.127341],
    ["442-Seoni",23.008,82.070675],
    ["443-Chilhati",22.079625,82.139141],
    ["444-Geedha",22.087381,81.73631],
    ["445-Agrasen Chowk",22.076991,82.152221],
    ["446-Jarhagaon",22.131797,81.825169],
    ["447-Lagra",22.110064,82.228447],
    ["448-Kenda",22.537429,82.067952],
    ["449-Khodri",22.665328,81.933021],
    ["450-Sadar Bazar Bilaspur",22.087755,82.144772],
    ["501-KUKDUR",22.099094,81.251883],
    ["502-KUNDA",22.116112,81.465602],
    ["503-PANDARIYA",22.194492,81.299948],
    ["504-Pandatarai",81.333736,81.333736],
    ["601-BHAISMA",22.2654,82.775],
    ["602-CHHURI",22.4821,82.6046],
    ["603-DEEPKA",22.3508,82.5464],
    ["604-GEVRA ROAD",22.3481,82.5397],
    ["605-HARDIBAZAR",22.3106,82.5471],
    ["606-JATGA",22.6945,82.3741],
    ["607-KARTALA",22.3001,82.9578],
    ["608-KATGHORA",22.5027,82.5445],
    ["609-KORBA",22.357,82.7219],
    ["610-KORBI",22.8627,82.4451],
    ["611-PALI",22.3731,82.3216],
    ["612-PASAN",22.8414,82.1961],
    ["613-JAMNIPALI",22.4167,82.6662],
    ["614-KORBA BUS STAND",22.3507,82.696],
    ["615-BALCO",22.3974,82.7454],
    ["616-BANKIMONGRA",22.4056,82.6086],
    ["701-ADBHAR",21.9507,83.0193],
    ["702-AKALTARA",22.0253,82.4271],
    ["703-BALAUDA",22.1341,82.4713],
    ["704-BAMHNIDIH",21.9008,82.7185],
    ["705-BARADWAR",22.0085,82.8157],
    ["706-BIRRA",21.7546,82.7773],
    ["707-CHAMPA",22.0359,82.6605],
    ["708-CHHAPORA",21.7897,82.9795],
    ["709-DABHARA",21.7804,83.0817],
    ["710-DHURKOT",21.8825,83.1455],
    ["711-FAGURAM",21.9474,83.0978],
    ["712-HASAUD",21.7543,82.9102],
    ["713-JAIJAIPUR",21.8311,82.8173],
    ["714-JANJGIR",22.0076,82.5785],
    ["715-JARVEY",22.0863,82.5269],
    ["716-KERA",21.7466,82.7072],
    ["717-NARIYARA",21.9418,82.3923],
    ["718-NAWAGARH",21.8514,82.6622],
    ["719-PANTORA",22.2366,82.6307],
    ["720-RAHOUD",21.8156,82.5075],
    ["721-SAKTI",22.0231,82.96],
    ["722-SAPOS",21.7557,83.1661],
    ["723-SEMRA",21.8664,82.597],
    ["724-SHEORINARAYAN",21.7209,82.59],
    ["726-CHANDRAPUR",21.7073,83.2315],
    ["727-MALKHARODA",21.8616,82.9845],
    ["728-PAMGARH",21.8756,82.4451],
    ["729-SALKHAN",21.8266,82.5787],
    ["730-NAILA",22.0132,82.5741],
    ["731-PAHARIYA",22.1172,82.6142],
    ["732-TILAI",21.9864,82.4968],
    ["733-SARAGAON",21.9417,82.9725],
    ["734-SAKARRA",21.9853,82.7538],
    ["735-Champa-2",21.896197,82.732435],
    ["801-BADE BHANDAR",21.7539,83.296],
    ["802-BADE NAVAPARA",21.5918,83.3809],
    ["803-BARAMKELA",21.562868,83.263981],
    ["804-BHEDWAN",21.6848,83.1193],
    ["805-BHUPDEOPUR",21.9733,83.1273],
    ["806-CHAKRADHAR NAGAR",21.893,83.4074],
    ["807-CHAPLE",21.9837,83.1862],
    ["808-CHHAL",21.1323,83.1193],
    ["809-CHHIND",21.5934,83.0375],
    ["810-CHIKHALI",21.7904,83.3174],
    ["811-DHARAMJAIGARH",22.446171,83.180978],
    ["812-DHOURABHATHA",22.451,83.4425],
    ["813-GERWANI",22.2691,83.2024],
    ["814-GHARGHODA",22.166,83.3443],
    ["815-HATI",22.3005,83.0924],
    ["816-JOBI",22.2691,83.2024],
    ["817-KABIRCHOUCK",83.387142,83.396377],
    ["818-KAPU",22.2691,83.2024],
    ["820-KHARSIYA",21.9876,83.0962],
    ["821-KIRODIMALNAGAR",21.92685,83.332295],
    ["822-KUSMURA",21.878017,83.318812],
    ["823-LAILUNGA",22.389958,83.582751],
    ["825-LENDHRA",21.643667,83.029424],
    ["826-LOING",21.856821,83.49369],
    ["828-NANDELI",21.889686,83.241233],
    ["829-NAVRANGPUR",21.636137,83.172491],
    ["830-NAVAPARA TENDA",22.138711,83.274684],
    ["831-PUSOUR",21.9,83.4],
    ["832-RAIGARH",21.8925,83.3977],
    ["833-RAJPUR",22.4121,83.5122],
    ["834-SALAR",21.5174,83.1318],
    ["835-SARANGARH",21.5883,83.0816],
    ["836-SARIYA",21.6398,83.3621],
    ["837-TAMNAR",22.0905,83.44],
    ["838-TOUSIR",21.5143,83.2789],
    ["839-DHIMARAPUR",21.9201,83.387142],
    ["840-KHAMHAR",22.401395,83.572295],
    ["841-KUDUMKELA",22.275995,83.277564],
    ["842-KOTARA ROAD",21.89,83.22],
    ["843-KODATARAI",21.829099,83.356231],
    ["844-DONGARIPALI",21.411411,83.333515],
    ["845-CHARKHAPARA",22.5155,83.4247],
    ["846-JAMGAON",21.851195,83.492553],
    ["847-GARH UMARIYA",21.862583,83.416593],
    ["848-JHARADIH",21.9914,83.0509],
    ["849-ULKHAR",21.660287,83.072378],
    ["850-LARA",21.721941,83.45902],
    ["851-PUTKAPURI",21.816956,83.276021],
    ["852-SALHEONA",21.898183,83.413753],
    ["853-BOIRDADAR",21.6582,83.2748],
    ["901-ASTA",23.119249,83.990298],
    ["903-BAGICHA",22.9506,83.6293],
    ["905-BANDARCHUNWA",22.644,83.743819],
    ["907-DULDULA",22.720053,84.106566],
    ["908-GAMHARIYA",22.8785,84.1629],
    ["909-GHOLENG",22.9114,84.2043],
    ["910-JASHPURNAGAR",22.8866,84.1379],
    ["911-KANSABEL",22.644,83.743819],
    ["912-KUNKURI",22.7375,83.951],
    ["913-LODAM",22.9556,84.3465],
    ["914-LUDEG",22.535258,83.618879],
    ["915-MAHADEODAND",22.8769556,83.84308],
    ["916-MANORA",23.119977,83.970458],
    ["917-NARAYANPUR",22.858228,83.913545],
    ["918-PATTHALGAON",22.556366,83.461021],
    ["919-FARSABAHAR",22.444547,83.953314],
    ["920-SANNA",23.085504,83.807521],
    ["921-TAMTA",22.638343,83.60025],
    ["922-TAPKARA",22.501996,83.949287],
    ["923-DOKDA",22.615353,83.88525],
    ["924-KERSAI",22.590096,83.963843],
    ["925-RANPUR",22.839417,83.810174],
    ["926-BAGBAHAR",22.54475,83.76233],
    ["927-ANKIRA",22.395089,83.908248],
    ["928-SONKYARI",23.039497,83.92149],
    ["929-PURANI TOLI",22.88742,84.138237],
    ["930-PATRA TOLI",22.88742,84.138237],
    ["1001-CHARAMA",20.4845,81.372261],
    ["1002-DUDHAWA",20.296619,81.740413],
    ["1003-KANKER",20.27,81.49],
    ["1004-KAPSI",20.09,80.67],
    ["1005-ANTAGARH",20.301897,81.038202],
    ["1006-KORAR",20.316582,81.269778],
    ["1007-SABER",19.927524,80.563288],
    ["1008-LAKHANPURI",20.396111,81.429722],
    ["1009-NARHARPUR",20.448985,81.620366],
    ["1010-SAMBALPUR",20.098476,81.15959],
    ["1011-BHANUPRATAP PUR",20.293163,81.074509],
    ["1012-Sarona",20.283202,81.644605],
    ["1013-HALBA",20.494997,81.502033],
    ["1014-Pakhanjore",20.039991,80.627141],
    ["1015-DURGKONDAL",20.448985,81.620366],
    ["1016-KANKER-2",20.272494,81.493133],
    ["1017-PURI(CHARAMA)",20.4419,81.265649],
    ["1018-MAKDI(TIRANA)",20.265794,81.497916],
    ["1019-UMRADAH ",20.7015,81.554158],
    ["1101-ANANTPUR",19.7222,81.6501],
    ["1102-BAHIGAON",19.6,81.67],
    ["1103-BANSKOT",19.3908,81.8279],
    ["1104-BENOOR",19.3636,81.183],
    ["1105-Chhotedongar",19.7069,81.2787],
    ["1106-DHANORA",19.3991,81.7514],
    ["1107-DHARAMPURA",19.07,82.03],
    ["1108-DARBHA",19.07,82.03],
    ["1109-GHOTIYA",18.9391,82.0584],
    ["1110-JAGDALPUR",19.1021,82.1795],
    ["1111-Karpawand",18.8666,81.8666],
    ["1112-KODENAR",19.2037,81.9344],
    ["1113-KONDAGAON",19.9574,81.6124],
    ["1114-KURANDI(Babu Semra)",19.3787,82.0897],
    ["1115-LANJODA",19.4503,81.2492],
    ["1116-MAKDI",19.3778,81.5432],
    ["1117-MARDAPAL",19.2831,82.1306],
    ["1118-NAGARNAR",19.2037,81.9344],
    ["1119-NANGOOR",19.07,82.03],
    ["1120-NARAYANPUR",19.6584,81.4401],
    ["1121-Orchha",19.7235,81.2424],
    ["1122-PHARASGAON",19.7185,81.7623],
    ["1123-RAIKOT",19.2747,81.8716],
    ["1124-SARGIPAL RLY Colony",19.0998,81.9889],
    ["1125-SHAMPUR",19.9938,81.8388],
    ["1126-SONARPAL",19.0124,81.8798],
    ["1127-USARIBEDA",18.9642,81.6583],
    ["1128-VISHRAMPURI",19.658,81.9917],
    ["1129-SURDONGAR, Keshkal",20.0991,81.5399],
    ["1130-BASTAR",19.2037,81.9344],
    ["1131-BADERAJPUR",20.7702,81.7459],
    ["1132-BANIYAGAON",19.9778,81.4993],
    ["1133-Titarwand",19.6,81.67],
    ["1137-RANDHANA",19.7593,81.4361],
    ["1138-AGRASEN CHOWK JAGDALPUR ",19.07,82.03],
    ["1139-MADPAL",19.0927,82.1319],
    ["1140-BADE DONGAR",19.7843,81.5267],
    ["1141-Karanji",19.2968,82.038],
    ["1201-BACHELI",19.1347,81.3894],
    ["1202-BARSOOR",18.9,81.35],
    ["1204-BHOPALPATNAM",18.7765,80.5369],
    ["1205-BIJAPUR",18.8639,80.38],
    ["1206-CHINDAGARH",18.7279,81.8101],
    ["1207-DANTEWADA",18.7946,81.6227],
    ["1208-DORNAPAL",18.1552,81.5089],
    ["1209-GEEDAM",18.9739,81.3991],
    ["1210-KATEKALYAN",18.7009,81.2491],
    ["1211-KIRANDUL",18.6336,81.2574],
    ["1212-KONTA",17.8075,81.3867],
    ["1213-BHAIRAMGARH",19.01,81.0617],
    ["1214-MADDED",18.7917,80.8167],
    ["1215-SUKMA",18.5254,81.76],
    ["1216-TONGPAL",18.3911,81.6593],
    ["1217-AAWRABHATA",18.9,81.35],
    ["1218-Kuwakonda",18.7275,81.4416],
    ["1219-Jawanga",18.973896,81.399096],
    ["1220-GADIRAS",19.074097,82.008014],
    ["1221-KERLAPAL",19.074097,82.008014],
    ["6002-AMBIKAPUR BRANCH",23.120945,83.202456],
    ["6003-JAINAGAR",23.169903,82.990474],
    ["6004-PATNA",23.287771,82.653746],
    ["6005-BARGIDIH",23.036713,83.41507],
    ["6006-PRATAPGARH",22.746758,83.49369],
    ["6007-BARBASPUR",22.645353,82.402132],
    ["6008-BARION",23.249296,83.317476],
    ["6009-SURAJPUR",23.218986,82.848312],
    ["6010-KRISHANPUR",23.22,82.85],
    ["6011-LAMGAON",23.055287,83.354895],
    ["6012-SEDAM",22.926765,83.436341],
    ["6013-DARIMA",22.995897,83.198836],
    ["6014-BASDEI",23.311667,82.8506],
    ["6015-LATORI",23.216349,83.103233],
    ["6016-KARONJEE",23.276954,82.934022],
    ["6017-PASTA",23.449615,83.531702],
    ["6018-BARTIKALA",23.757951,83.686697],
    ["6019-SARBHOKA",23.251651,82.331624],
    ["6020-BANSHIPUR",23.354731,83.084453],
    ["6021-PONDI BACHRA",23.258104,82.71583],
    ["6022-LAKHANPUR",22.466297,82.530759],
    ["6023-MENDRAKALA",23.074806,83.119276],
    ["6024-PREMNAGAR",22.969041,82.675347],
    ["6025-SALKA",23.401903,82.923617],
    ["6026-CHANDRAMERHA",23.22,82.85],
    ["6027-MAHARAJGANJ",23.585663,83.711943],
    ["6028-DANDGAON",22.914835,82.8506],
    ["6029-KATKONA",22.975287,82.307201],
    ["6030-KELHARI",23.411893,82.046162],
    ["6031-JANAKPUR",23.719072,81.788271],
    ["6032-KAMLESHWARPUR",22.829714,83.277359],
    ["6033-ODGI",23.285246,82.537522],
    ["6034-WADRAFNAGAR",23.760487,83.201284],
    ["6035-CHANDO",23.537202,83.834044],
    ["6036-BHATGAON",23.362278,82.987787],
    ["6037-RAMANUJGANJ",23.8,83.7],
    ["6038-PONDRIHILL",23.102186,82.384959],
    ["6039-SHANKARGARH",23.309133,83.616218],
    ["6040-SUKHARI",23.518157,83.802215],
    ["6041-DEEPADIH",23.288382,83.726555],
    ["6042-KATGODI",23.376849,82.534817],
    ["6043-PARSA",23.184907,83.266657],
    ["6044-PANDOPARA",23.321321,82.535541],
    ["6045-KAMARI",23.330013,83.546993],
    ["6046-JAMWANTPUR",23.70837,83.669417],
    ["6047-GUTURAMA",22.698875,83.483025],
    ["6048-PETLA",22.747557,83.58694],
    ["6049-BATAULI",22.98067,83.413653],
    ["6050-KALYANPUR",23.229552,83.202408],
    ["6051-FUNDURDIHARI",23.124583,83.183734],
    ["6052-SITAPUR",22.780925,83.49545],
    ["6053-KUMDA",23.228418,82.97435],
    ["6054-PONDI WEST CHIRIMIRI",23.145729,82.979725],
    ["6055-KANJIYA",23.640058,81.663777],
    ["6056-JHAGRAKHAND",23.193266,82.197193],
    ["6057-PANDRI",23.839264,83.062984],
    ["6058-KEWARA",23.426278,83.095185],
    ["6059-KETKA",23.155589,82.869446],
    ["6060-DARRIPARA",23.395021,82.812218],
    ["6061-TARA",22.841706,82.740109],
    ["6062-DHARAMPUR",23.382657,83.180978],
    ["6063-GOVINDPUR",23.244527,82.970318],
    ["6064-MANENDRAGARH",23.213891,82.201276],
    ["6065-SILIFILI",23.175836,83.066003],
    ["6066-KUSMI",23.285152,83.908248],
    ["6067-DABRA",23.522029,83.461688],
    ["6068-CHALGALI",23.316571,83.653462],
    ["6069-UDAIPUR",22.908384,82.947277],
    ["6070-REHDA",23.757951,83.686697],
    ["6071-SOHGA",23.04084,83.223831],
    ["6072-DEONAGAR",23.226672,82.760053],
    ["6073-RAMANUJNAGAR",23.148691,82.718528],
    ["6074-BAIKUNTHPUR",23.25,82.55],
    ["6075-BALARAMPUR",23.833409,82.934022],
    ["6076-RAGHUNATHNAGAR",23.313519,82.448194],
    ["6077-BALANGI",23.874759,82.804809],
    ["6078-KRISHNANAGAR",23.282467,83.839347],
    ["6079-PRATAPPUR",23.487132,83.19973],
    ["6080-CHURCHA",23.334267,82.51992],
    ["6081-NAGPUR",23.288719,82.34858],
    ["6082-BHAIYATHAN",23.213632,82.870216],
    ["6083-RAJPUR",23.336324,83.413653],
    ["6084-SONHAT",23.471007,82.523995],
    ["6085-SONGARA",23.29597,83.095185],
    ["6087-SANAWAL",24.032888,83.360239],
    ["6088-BARTUNGA",23.102186,82.384959],
    ["6089-GANDHINAGAR",23.145539,83.174765],
    ["6090-KERATA",23.335266,83.180978],
    ["6091-SHIVNANDANPUR",23.194539,82.978381],
    ["6092-LAXMIPUR",22.464851,83.208121],
    ["6093-BAIKUNTHPUR (EXTN COUNTER)",23.145729,82.979725],
    ["6094-RAMGARH",23.600964,81.816971],
    ["6095-BIHARPUR",23.256639,83.076403],
    ["6096-PUHPUTRA",23.045726,83.062984],
    ["6097-MAHAVIRPUR (AJIRMA)",23.146657,83.135414],
    ["6098-BATRA",23.290247,82.966286],
    ["6099-MAANI MOD",23.511988,83.226509],
    ["6100-RAMCHANDRAPUR",23.928976,83.491024],
    ["6101-CHIRMI",23.129282,82.556456],
    ["6102-NAVAPARAKALA",23.025753,82.621331],
    ["6103-SHIVNAGAR",22.899577,82.775162],
    ["6104-SALKA(Tuthipakdi)",23.371379,82.933732],
    ["6105-GODHAPUR",23.1433,83.190751],
    ["6107-RAGHUNATHPUR",23.065792,83.322823],
    ["6109-Surajpur Collectorate",23.271349,82.556456],
    ["6110-Shivprasad Nagar",23.271349,82.556456],
    ["8102-AHIWARA MAR",21.3565862,81.4114142],
    ["8103-ANJORA",21.1557778,81.2147035],
    ["8104-ARJUNDA",20.9454037,81.2036839],
    ["8105-ARMARIKALA",20.8391153,81.4086665],
    ["8106-BALOD",20.75054873,81.20274658],
    ["8107-BATREL",20.8985071,81.4141618],
    ["8108-Bemetara",21.714025,81.535615],
    ["8109-BHILAI 3",21.1844874,81.3520561],
    ["8110-SIKOSA",20.87388965,81.28179073],
    ["8111-BORI",21.1442822,81.0520052],
    ["8112-CHANDKHURI",21.1369533,81.2644438],
    ["8113-CHIKHLAKASA",20.5999157,81.0775354],
    ["8114-Dadhi",21.711231,82.216219],
    ["8115-CHARODA",21.2318315,81.4581101],
    ["8116-Deokar",21.711231,82.216219],
    ["8117-Deorbija",21.711231,82.216219],
    ["8118-DEORI",21.4666925,80.8682203],
    ["8119-DHAMDHA",21.4603109,81.330315],
    ["8120-DONDI",20.4858079,81.0837442],
    ["8121-DONDI -LOHARA",20.790105,81.0575259],
    ["8122-DALLI RAJHARA",20.61599397,81.08274658],
    ["8123-DUDHELI",20.768248,81.1485621],
    ["8124-GHOTIYA",21.3241149,80.9622388],
    ["8125-GURUR",20.6851544,81.4031707],
    ["8126-HALDI",20.8205946,81.3344408],
    ["8127-Hasda",21.711231,82.216219],
    ["8128-JSANKRA",20.8228582,81.2050614],
    ["8129-Jeora",21.711231,82.216219],
    ["8130-JEORA SIRSA",21.25834137,81.30569458],
    ["8131-KARHIBHADAR",20.6936853,81.3083072],
    ["8132-Khandsara",21.711231,82.216219],
    ["8133-Kodwa",21.711231,82.216219],
    ["8134-KUMHARI",21.2526246,81.5184973],
    ["8135-KURUD",20.8344923,81.72068665],
    ["8136-Kusmi",21.711231,82.216219],
    ["8137-LATABOD",20.7894499,81.2594547],
    ["8138-Maro",21.711231,82.216219],
    ["8139-M JAMGAON",21.1419447,81.5226128],
    ["8140-NAGPURA",21.2523262,81.2243444],
    ["8141-Nandghat",21.711231,82.216219],
    ["8142-NANKATHI",21.3364381,81.335816],
    ["8143-Nawagarh",21.711231,82.216219],
    ["8144-NIKUM",21.0575451,81.2009287],
    ["8145-PALLARI",20.8170376,81.4992884],
    ["8146-Parpodi",21.711231,82.216219],
    ["8147-PINKAPAR",20.9717808,80.960166],
    ["8148-PURUR",20.665192,81.484566],
    ["8149-RENGADABRI",20.7724703,80.9048731],
    ["8150-RISALI",21.1606269,81.3371911],
    ["8151-POTIYAKALA",21.1796354,81.2816188],
    ["8152-R JAMGAON",21.1492682,81.521241],
    ["8153-Saja",21.711231,82.216219],
    ["8154-Sambalpur",21.908742,81.743149],
    ["8155-SELOOD",21.0961834,81.430731],
    ["8156-Bhimbhori",21.413363,81.598025],
    ["8157-UTAI",21.1175002,81.38031],
    ["8158-SUPELA",21.2108165,81.3516936],
    ["8159-SAFBHILAI",21.1991874,81.3110585],
    ["8160-GUNDERDEHI",20.9458953,81.2898612],
    ["8161-Thankhamariya",21.66357,81.316561],
    ["8162-Patan",21.0357648,81.5456384],
    ["8163-Berla",21.715851,81.538009],
    ["8164-ANDA",21.0629366,81.2766598],
    ["8165-Murmunda",21.3068027,81.4642882],
    ["8166-AMLESHWAR",21.2069257,81.5802069],
    ["8167-Basin",20.9165189,81.4196567],
    ["8168-Pendarwani",21.0644535,80.8571521],
    ["8169-Arkar",20.8518449,81.4678238],
    ["8170-Bargaon",21.53741,81.595804],
    ["8171-HUDCO Bhilai",21.1872225,81.3083072],
    ["8172-Sikolabhata",21.1987512,81.2811325],
    ["8173-Balsamund",21.723187,81.641866],
    ["8174-Jhalmala",20.71608,81.24018],
    ["8175-Nipani",20.759796,81.344754],
    ["8176-Kalangpur",20.905595,81.335128],
    ["8201-RAJNANDGAON",21.099666,81.032969],
    ["8202-ATARIYA",21.656862,80.942891],
    ["8203-BANDHA BAJAR",20.86157,80.654888],
    ["8204-BDIVANBHEDI",20.920806,80.87652],
    ["8205-BHARRITOLA",21.038455,81.317936],
    ["8206-BODLA",21.900438,81.075466],
    ["8207-BORTALAO",21.269125,80.76578],
    ["8208-CHICHOLA",21.080163,80.76578],
    ["8209-CHILHATI",20.86157,80.654888],
    ["8210-CHHUIKHADAN",21.526155,80.995707],
    ["8211-CHHURIYA",20.975948,80.58828],
    ["8212-DANGARH",20.701184,80.801658],
    ["8213-DASHRANGPUR",21.894885,81.381108],
    ["8214-DHARA",21.269125,80.76578],
    ["8215-DONGARGAON",20.972108,80.838068],
    ["8216-DONGARGARH",21.184412,80.756378],
    ["8217-GANDAI",21.656862,80.942891],
    ["8218-GENDATOLA",20.975948,80.58828],
    ["8219-GOTATOLA",20.590143,80.87652],
    ["8220-JALBANDHA",21.30596,81.009206],
    ["8221-KARMARI",20.920806,80.87652],
    ["8222-KAUDIKASA",20.702308,80.76578],
    ["8223-KAWARDHA",22.004883,81.245754],
    ["8224-KHADGAON",20.319864,80.677079],
    ["8225-KHAIRAGARH",21.423356,80.982101],
    ["8226-KOKPUR",20.975948,80.58828],
    ["8227-KUMARDA",20.86157,80.654888],
    ["8228-LB NAGAR",21.080163,80.76578],
    ["8229-M MACHANDUR",21.656862,80.942891],
    ["8230-MUSRA",21.269125,80.76578],
    ["8231-PANDADAH",21.462981,80.854385],
    ["8232-PONDI",21.900438,81.075466],
    ["8233-RANVEERPUR",22.288245,81.251883],
    ["8234-RAWELI",21.900438,81.075466],
    ["8235-SCHIRCHARI",21.080163,80.76578],
    ["8236-SLOHARA",21.900438,81.075466],
    ["8237-SALHEWARA",21.656862,80.942891],
    ["8238-SILHATI",21.900438,81.075466],
    ["8239-SURGI",21.097103,81.030222],
    ["8240-TEDESARA",21.097103,81.030222],
    ["8241-THELKADIH",21.314044,81.025243],
    ["8242-TUMDIBOD",21.097103,81.030222],
    ["8243-AMBAGARH CHOWKI",20.777689,80.747794],
    ["8244-GHUMKA",21.30596,81.009206],
    ["8245-MOHLA",20.579858,80.758417],
    ["8246-ARJUNI",21.097103,81.030222],
    ["8247-Pandariya",21.900438,81.075466],
    ["8248-Dilapahari",21.097103,81.030222],
    ["8249-Singhola",21.031425,81.043268],
    ["8250-Krishi Upaj Mandi",21.084032,81.021214],
    ["8251-Manpur",20.150261,80.861701],
    ["8252-Rajanavagaon",21.900438,81.075466],
    ["8253-Kamthee",22.288245,81.251883],
    ["8254-Baijalpur",21.900438,81.075466],
    ["8255-Bharregaon",21.097103,81.030222],
    ["8256-UMARWAHI",20.84315,80.859919],
    ["8257-BHOLAPUR",20.985834,80.660436],
    ["8258-UPARWAH",21.097103,81.030222],
    ["8788-DURG",21.21560655,81.29098633],
    ["60108-Kedma",22.760329,83.041508],    
];

function setMarkers(map) {
  // Adds markers to the map.
  // Marker sizes are expressed as a Size of X,Y where the origin of the image
  // (0,0) is located in the top left of the image.
  // Origins, anchor positions and coordinates of the marker increase in the X
  // direction to the right and in the Y direction down.
  const image = {
    url: "https://developers.google.com/maps/documentation/javascript/examples/full/images/beachflag.png",
    // This marker is 20 pixels wide by 32 pixels high.
    size: new google.maps.Size(15, 25),
    // The origin for this image is (0, 0).
    origin: new google.maps.Point(0, 0),
    // The anchor for this image is the base of the flagpole at (0, 32).
    anchor: new google.maps.Point(0, 32),
  };
  // Shapes define the clickable region of the icon. The type defines an HTML
  // <area> element "poly" which traces out a polygon as a series of X,Y points.
  // The final coordinate closes the poly by connecting to the first coordinate.
  const shape = {
    coords: [1, 1, 1, 20, 18, 20, 18, 1],
    type: "poly",
  };

  const flightPlanCoordinates = [
    { lat: 37.772, lng: -122.214 },
    { lat: 21.291, lng: -157.821 },
    { lat: -18.142, lng: 178.431 },
    { lat: -27.467, lng: 153.027 },
  ];

  

  for (let i = 0; i < beaches.length; i++) {
    const beach = beaches[i];

    new google.maps.Marker({
      position: { lat: beach[1], lng: beach[2] },
      map,
      icon: image,
      shape: shape,
      title: beach[0],
    });
  }
}

window.initMap = initMap;
