using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace States
{
    class States
    {
        static string abia = @"
============================
1.	ABA NORTH
2.	ABA SOUTH
3.	AROCHUKWU
4.	BENDE
5.	IKWUANO
6.	ISIKWUATO
7.	OHAFIA
8.	OSISIOMA NGWA
9.	UGWUNAGBO";
        static string abuja = @"
============================
1.	GWAGWALADA
2.	KUJE
3.	ABAJI
4.	ABUJA MUNICIPAL
5.	BWARI
6.	KWALI";
        static string adamawa = @"
=============================
1.	DEMSA
2.	FUFORE
3.	GANYE
4.	GAYUK
5.	GIREI
6.	GOMBI
7.	GUYUK
8.	JADA
9.	LAMURDE
10.	MADAGALI
11.	MAIHA
12.	MAYO BELWA
13.	MICHIKA
14.	MUBI NORTH
15.	MUBI SOUTH
16.	NUMAN, NIGERIA
17.	SHELLENG
18.	SONG
19.	TOUNGO
20.	YOLA NORTH
21.	YOLA SOUTH";
        static string akwaibom = @"
===================================
1.	Abak
2.	Eastern Obolo
3.	Eket
4.	Esit-Eket
5.	Essien Udim
6.	Etim-Ekpo
7.	Etinan
8.	Ibeno
9.	Ibesikpo-Asutan
10.	Ibiono-Ibom
11.	Ika
12.	Ikono
13.	Ikot Abasi
14.	Ikot Ekpene
15.	Ini
16.	Itu
17.	Mbo
18.	Mkpat-Enin
19.	Nsit-Atai
20.	Nsit-Ibom
21.	Nsit-Ubium
22.	Obot-Akara
23.	Okobo
24.	Onna
25.	Oron
26.	Oruk Anam
27.	Ukanafun
28.	Udung-Uko
29.	Uruan
30.	Urue-Offong/Oruko
31.	Uyo";
        static string anambra = @"
=================================
1.	Aguata
2.	Awka North
3.	Awka South
4.	Anambra East
5.	Anambra West
6.	Anaocha
7.	Ayamelum
8.	Dunukofia
9.	Ekwusigo
10.	Idemili North
11.	Idemili South
12.	Ihiala
13.	Njikoka
14.	Nnewi North
15.	Nnewi South
16.	Ogbaru
17.	Onitsha North
18.	Onitsha South
19.	Orumba North
20.	Orumba South
21.	Oyi";
        static string bauchi = @"
==============================
1.	Bauchi
2.	Tafawa Balewa
3.	Dambam
4.	Darazo
5.	Dass
6.	Toro
7.	Bogoro
8.	Ningi
9.	Warji
10.	Ganjuwa
11.	Kirfi
12.	Alkaleri
13.	Misau
14.	Giade
15.	Shira
16.	Jama’are
17.	Katagum
18.	Itas/Gadau
19.	Zaki
20.	Gamawa";
        static string bayelsa = @"
=============================
1.	Brass
2.	Ekeremor
3.	Kolokuma/Opokuma
4.	Nembe
5.	Ogbia
6.	Sagbama
7.	Southern Ijaw
8.	Yenagoa";
        static string benue = @"
1.	Ado
2.	Agatu
3.	Apa
4.	Buruku
5.	Gboko
6.	Guma
7.	Gwer East
8.	Gwer West
9.	Katsina Ala
10.	Konshisha
11.	Kwande
12.	Logo
13.	Makurdi
14.	Obi
15.	Ogbadibo
16.	Ohimini
17.	Oju
18.	Okpokwu
19.	Otukpo
20.	Tarka
21.	Ukum
22.	Ushongo
23.	Vandeikya";
        static string borno= @"
================================
1.	Maiduguri
2.	Ngala
3.	Kala/Balge
4.	Mafa
5.	Konduga
6.	Bama
7.	Jere
8.	Dikwa
9.	Askira/Uba
10.	Bayo
11.	Biu
12.	Chibok
13.	Damboa
14.	Gwoza
15.	Hawul
16.	Kwaya Kusar
17.	Shani
18.	Abadam
19.	Gubio
20.	Guzamala
21.	Kaga
22.	Kukawa
23.	Magumeri
24.	Marte
25.	Mobbar
26.	Monguno
27.	Nganzai";
        static string crossriver = @"
====================================
1.	Abi
2.	Akamkpa
3.	Akpabuyo
4.	Bakassi
5.	Bekwarra
6.	Biase
7.	Boki
8.	Calabar Municipal
9.	Calabar South
10.	Etung
11.	Ikom
12.	Obanliku
13.	Obubra
14.	Obudu
15.	Odukpani
16.	Ogoja
17.	Yakuur
18.	Yala";
        static string delta = @"
1.	Ethiope East
2.	Ethiope West
3.	Okpe
4.	Sapele
5.	Udu
6.	Ughelli North
7.	Ughelli South
8.	Uvwie
9.	Aniocha North
10.	Aniocha South
11.	Ika North East
12.	Ika South
13.	Ndokwa East
14.	Ndokwa West
15.	Oshimili North
16.	Oshimili South
17.	Ukwuani
18.	Bomadi
19.	Burutu
20.	Isoko North
21.	Isoko South
22.	Patani
23.	Warri North
24.	Warri South
25.	Warri South West
";
        static string ebonyi = @"
===============================
1.	Abakaliki
2.	Afikpo North
3.	Afikpo South
4.	Ebonyi
5.	Ezza North
6.	Ezza South
7.	Ikwo
8.	Ishielu
9.	Ivo
10.	Izzi
11.	Ohaozara
12.	Ohaukwu
13.	Onicha
";
        static string enugu = @"
=================================
1.	Aninri
2.	Awgu
3.	Enugu East
4.	Enugu North
5.	Enugu South
6.	Ezeagu
7.	Igbo Etiti
8.	Igbo Eze North
9.	Igbo Eze South
10.	Isi Uzo
11.	Nkanu East
12.	Nkanu West
13.	Nsukka
14.	Oji River
15.	Udenu
16.	Udi
17.	Uzo-Uwani";
        static string edo= @"
=============================
1.	Akoko-Edo
2.	Egor
3.	Esan Central
4.	Esan North-East
5.	Esan South-East
6.	Esan West
7.	Etsako Central
8.	Etsako East
9.	Etsako West
10.	Igueben
11.	Ikpoba-Okha
12.	Oredo
13.	Orhionmwon
14.	Ovia North-East
15.	Ovia South-West
16.	Owan East
17.	Owan West
18.	Uhunmwonde";
        static string ekiti = @"
==================================
1.	Ado-Ekiti
2.	Ikere
3.	Oye
4.	Aiyekire (formerly Gbonyin)
5.	Efon
6.	Ekiti East
7.	Ekiti South-West
8.	Ekiti West
9.	Emure
10.	Ido-Osi
11.	Ijero
12.	Ikole
13.	Ilejemeje
14.	Irepodun/Ifelodun
15.	Ise/Orun
16.	Moba";
        static string gombe = @"
================================
1.	Akko
2.	Balanga
3.	Biliri
4.	Dukku
5.	Funakaye
6.	Gombe
7.	Kaltungo
8.	Kwami
9.	Nafada
10.	Shongom
11.	Yamaltu/Deba";
        static string imo = @"
===============================
1.	Aboh Mbaise
2.	Ahiazu Mbaise
3.	Ehime Mbano
4.	Ezinihitte Mbaise
5.	Ideato North
6.	Ideato South
7.	Ihitte/Uboma
8.	Ikeduru
9.	Isiala Mbano
10.	Isu
11.	Mbaitoli
12.	Ngor Okpala
13.	Njaba
14.	Nkwerre
15.	Nwangele
16.	Obowo
17.	Oguta
18.	Ohaji/Egbema
19.	Okigwe
20.	Onuimo
21.	Orlu
22.	Orsu
23.	Oru East
24.	Oru West
25.	Owerri Municipal
26.	Owerri North
27.	Owerri West";
        static string jigawa = @"
==============================
1.	Auyo
2.	Babura
3.	Birniwa
4.	Birnin Kudu
5.	Buji
6.	Dutse
7.	Gagarawa
8.	Garki
9.	Gumel
10.	Guri
11.	Gwaram
12.	Gwiwa
13.	Hadejia
14.	Jahun
15.	Kafin Hausa
16.	Kaugama
17.	Kazaure
18.	Kiri Kasama
19.	Kiyawa
20.	Maigatari
21.	Malam Madori
22.	Miga
23.	Ringim
24.	Roni
25.	Sule Tankarkar
26.	Taura
27.	Yankwashi";
        static string kaduna = @"
===============================
1.	Birnin Gwari
2.	Chikun
3.	Giwa
4.	Igabi
5.	Ikara
6.	Jaba
7.	Jema’a
8.	Kachia
9.	Kaduna North
10.	Kaduna South
11.	Kagarko
12.	Kajuru
13.	Kaura
14.	Kauru
15.	Kubau
16.	Kudan
17.	Lere
18.	Makarfi
19.	Sabon Gari
20.	Sanga
21.	Soba
22.	Zangon Kataf
23.	Zaria
";
        static string kano = @"
==============================
1.	Ajingi
2.	Albasu
3.	Bagwai
4.	Bebeji
5.	Bichi
6.	Bunkure
7.	Dala
8.	Dambatta
9.	Dawakin Kudu
10.	Dawakin Tofa
11.	Doguwa
12.	Fagge
13.	Gabasawa
14.	Garko
15.	Garun Mallam
16.	Gaya
17.	Gezawa
18.	Gwale
19.	Gwarzo
20.	Kabo
21.	Kano Municipal
22.	Karaye
23.	Kibiya
24.	Kiru
25.	Kumbotso
26.	Kunchi
27.	Kura
28.	Madobi
29.	Makoda
30.	Minjibir
31.	Nasarawa
32.	Rano
33.	Rimin Gado
34.	Rogo
35.	Shanono
36.	Sumaila
37.	Takai
38.	Tarauni
39.	Tofa
40.	Tsanyawa
41.	Tudun Wada
42.	Ungogo
43.	Warawa
44.	Wudil";
        static string katsina = @"
==============================
1.	Bakori
2.	Batagarawa
3.	Batsari
4.	Baure
5.	Bindawa
6.	Charanchi
7.	Dan Musa
8.	Dandume
9.	Danja
10.	Daura
11.	Dutsi
12.	Dutsin-Ma
13.	Faskari
14.	Funtua
15.	Ingawa
16.	Jibia
17.	Kafur
18.	Kaita
19.	Kankara
20.	Kankia
21.	Katsina
22.	Kurfi
23.	Kusada
24.	Mai’Adua
25.	Malumfashi
26.	Mani
27.	Mashi
28.	Matazu
29.	Musawa
30.	Rimi
31.	Sabuwa
32.	Safana
33.	Sandamu
34.	Zango
";
        static string kebbi = @"
======================================
1.	Aliero
2.	Arewa Dandi
3.	Argungu
4.	Augie
5.	Bagudo
6.	Birnin Kebbi
7.	Bunza
8.	Dandi
9.	Fakai
10.	Gwandu
11.	Jega
12.	Kalgo
13.	Koko/Besse
14.	Maiyama
15.	Ngaski
16.	Sakaba
17.	Shanga
18.	Suru
19.	Danko/Wasagu
20.	Yauri
21.	Zuru
";
        static string kogi= @"
==============================
1.	Adavi
2.	Ajaokuta
3.	Ankpa
4.	Bassa
5.	Dekina
6.	Ibaji
7.	Idah
8.	Igalamela-Odolu
9.	Ijumu
10.	Kabba/Bunu
11.	Koton Karfe
12.	Lokoja
13.	Mopa-Muro
14.	Ofu
15.	Ogori/Magongo
16.	Okehi
17.	Okene
18.	Olamaboro
19.	Omala
20.	Yagba East
21.	Yagba West
";
        static string kwara = @"
==============================
1.	Asa
2.	Baruten
3.	Edu
4.	Ekiti
5.	Ifelodun
6.	Ilorin East
7.	Ilorin South
8.	Ilorin West
9.	Irepodun
10.	Isin
11.	Kaiama
12.	Moro
13.	Offa
14.	Oke Ero
15.	Oyun
16.	Patigi
";
        static string lagos = @"
============================
1.	Agege
2.	Ajeromi-Ifelodun
3.	Alimosho
4.	Amuwo-Odofin
5.	Apapa
6.	Badagry
7.	Epe
8.	Eti-Osa
9.	Ibeju-Lekki
10.	Ifako-Ijaiye
11.	Ikeja
12.	Ikorodu
13.	Kosofe
14.	Lagos Island
15.	Lagos Mainland
16.	Mushin
17.	Ojo
18.	Oshodi-Isolo
19.	Shomolu
20.	Surulere
";
        static string nasarawa = @"
===============================
1.	Akwanga
2.	Awe
3.	Doma
4.	Karu
5.	Keana
6.	Keffi
7.	Kokona
8.	Lafia
9.	Nasarawa
10.	Nasarawa-Eggon
11.	Obi
12.	Toto
13.	Wamba
";
        static string niger = @"
==============================
1.	Agaie
2.	Agwara
3.	Bida
4.	Borgu
5.	Bosso
6.	Chanchaga
7.	Edati
8.	Gbako
9.	Gurara
10.	Katcha
11.	Kontagora
12.	Lapai
13.	Lavun
14.	Magama
15.	Mariga
16.	Mashegu
17.	Mokwa
18.	Munya
19.	Paikoro
20.	Rafi
21.	Rijau
22.	Shiroro
23.	Suleja
24.	Tafa
25.	Wushishi
";
        static string ogun = @"
==================================
1.	Abeokuta North
2.	Abeokuta South
3.	Ado-Odo/Ota
4.	Ewekoro
5.	Ifo
6.	Ijebu East
7.	Ijebu North
8.	Ijebu North-East
9.	Ijebu Ode
10.	Ikenne
11.	Imeko Afon
12.	Ipokia
13.	Obafemi Owode
14.	Odogbolu
15.	Odeda
16.	Ogun Waterside
17.	Remo North
18.	Sagamu
19.	Yewa North
20.	Yewa South
";
        static string ondo = @"
===========================
1.	Akoko North-East
2.	Akoko North-West
3.	Akoko South-East
4.	Akoko South-West
5.	Akure North
6.	Akure South
7.	Ese Odo
8.	Idanre
9.	Ifedore
10.	Ilaje
11.	Ile Oluji/Okeigbo
12.	Irele
13.	Odigbo
14.	Okitipupa
15.	Ondo East
16.	Ondo West
17.	Ose
18.	Owo
";
        static string osun = @"
==============================
1.	Aiyedaade
2.	Aiyedire
3.	Atakumosa East
4.	Atakumosa West
5.	Boluwaduro
6.	Boripe
7.	Ede North
8.	Ede South
9.	Egbedore
10.	Ejigbo
11.	Ife Central
12.	Ife East
13.	Ife North
14.	Ife South
15.	Ifedayo
16.	Ifelodun
17.	Ila
18.	Ilesha East
19.	Ilesha West
20.	Irepodun
21.	Irewole
22.	Isokan
23.	Iwo
24.	Obokun
25.	Odo-Otin
26.	Ola-Oluwa
27.	Olorunda
28.	Oriade
29.	Orolu
30.	Osogbo
";
        static string oyo = @"
1.	Akinyele
2.	Afijio
3.	Egbeda
4.	Ibadan North
5.	Ibadan North-East
6.	Ibadan North-West
7.	Ibadan South-West
8.	Ibadan South-East
9.	Ibarapa Central
10.	Ibarapa East
11.	Ido
12.	Irepo
13.	Iseyin
14.	Kajola
15.	Lagelu
16.	Ogbomoso North
17.	Ogbomoso South
18.	Oyo West
19.	Atiba
20.	Atisbo
21.	Saki West
22.	Saki East
23.	Itesiwaju
24.	Iwajowa
25.	Ibarapa North
26.	Olorunsogo
27.	Oluyole
28.	Ogo Oluwa
29.	Surulere
30.	Orelope
31.	Ori Ire
32.	Oyo East
33.	Ona Ara
";
        static string plateau = @"
===================================
1.	Barkin Ladi
2.	Bassa
3.	Bokkos
4.	Jos East
5.	Jos North
6.	Jos South
7.	Kanam
8.	Kanke
9.	Langtang North
10.	Langtang South
11.	Mangu
12.	Mikang
13.	Pankshin
14.	Qua’an Pan
15.	Riyom
16.	Shendam
17.	Wase";
        static string rivers = @"
==============================
1.	Abua/Odual
2.	Ahoada East
3.	Ahoada West
4.	Akuku Toru
5.	Andoni
6.	Asari-Toru
7.	Bonny
8.	Degema
9.	Emohua
10.	Eleme
11.	Etche
12.	Gokana
13.	Ikwerre
14.	Khana
15.	Obio/Akpor
16.	Ogba/Egbema/Ndoni
17.	Ogu/Bolo
18.	Okrika
19.	Omuma
20.	Opobo Nkoro
21.	Oyigbo
22.	Port Harcourt
23.	Tai";
        static string sokoto = @"
===============================
1.	Binji
2.	Bodinga
3.	Dange Shuni
4.	Gada
5.	Goronyo
6.	Gudu
7.	Gwadabawa
8.	Illela
9.	Isa
10.	Kebbe
11.	Kware
12.	Rabah
13.	Sabon Birni
14.	Shagari
15.	Silame
16.	Sokoto North
17.	Sokoto South
18.	Tambuwal
19.	Tangaza
20.	Tureta
21.	Wamako
22.	Wurno
23.	Yabo";
        static string taraba = @"
==============================
1.	Ardo Kola
2.	Bali
3.	Donga
4.	Gashaka
5.	Gassol
6.	Ibi
7.	Jalingo
8.	Karim Lamido
9.	Kurmi
10.	Lau
11.	Sardauna
12.	Takum
13.	Ussa
14.	Wukari
15.	Yorro
16.	Zing";
        static string yobe = @"
===============================
1.	Bade
2.	Bursari
3.	Damaturu
4.	Geidam
5.	Gujba
6.	Gulani
7.	Fika
8.	Fune
9.	Jakusko
10.	Karasuwa
11.	Machina
12.	Nangere
13.	Nguru
14.	Potiskum
15.	Tarmuwa
16.	Yunusari
17.	Yusufari";
        static string zamfara = @"
================================
1.	Anka
2.	Bakura
3.	Birnin Magaji/Kiyaw
4.	Bukkuyum
5.	Bungudu
6.	Tsafe
7.	Gummi
8.	Gusau
9.	Kaura Namoda
10.	Maradun
11.	Maru
12.	Shinkafi
13.	Talata Mafara
14.	Zurmi";
            static void Main(string[] args)
        {
            Display();
            WriteLine();
            ReadLine();
          
        }
        static void Display()
        {
            incorrect:
            WriteLine("Press 1 to display all the states and FCT");
            WriteLine("Press 2 to display all the geopolitical zones");
            bool success = int.TryParse(ReadLine(), out int a);
            if (success && a== 1)
            {
                ListOfStates();
                WriteLine();
                Display3();
             }
            else if (success && a==2)
            {
                ListOfZones();
                Display2();
            }
            else
            {
                goto incorrect;
            }
        }
        static void Display2()
        {
        wrong:
            WriteLine();
            WriteLine("Press The number in front of the zone you want to list all of its states");
            WriteLine("Press 0 if you want to go to the previous menu");
            bool success = int.TryParse(ReadLine(), out int a);
            if (success && a == 0)
            {   
                Display();
            }
            else if (success && a == 1)
            {

                NorthCentral();
                Display4();
            }
            else if (success && a == 2)
            {
                NorthEast();
                Display5();
            }
            else if (success && a == 3)
            {

                NorthWest();
                Display6();
            }
            else if (success && a == 4)
            {
                SouthEast();
                Display7();
            }
            else if (success && a == 5)
            {

                SouthSouth();
                Display9();
            }
           else if (success && a == 6)
            {
                
                SouthWest();
                Display8();
            }
            else
            {
                goto wrong;
            }
        }
        static void Display3()
        {
            Display10();   
        }
        static void Display4()
        {
            wrong:
            WriteLine();
            WriteLine("Press The number in front of the state you want to list all of its LGAs");
            WriteLine("Press 0 if you want to go to the previous menu");
            WriteLine("Press 10 if you want to go to the main menu");
            bool success = int.TryParse(ReadLine(), out int a);
            if (success && a == 0)
            {
                ListOfZones();
                Display2();
            }
            else if (success && a == 10)
            {
                Display();
            }
            else if (success && a == 1)
            {
                DisplayBenue();
            }
            else if (success && a == 2)
            {
                 DisplayKogi();
            }
            else if (success && a == 3)
            {
                DisplayKwara();
            }
            else if (success && a == 4)
            {
                DisplayNasarawa();
            }
            else if (success && a == 5)
            {
                DisplayNiger();
            }
            else if (success && a == 6)
            {
                DisplayPlateau();
            }
            else if (success && a == 7)
            {
                DisplayAbuja();
            }
            else
            {
                goto wrong;
            }
        }
        static void Display5()
        {
        wrong:
            WriteLine();
            WriteLine("Press The number in front of the state you want to list all of its LGAs");
            WriteLine("Press 0 if you want to go to the previous menu");
            WriteLine("Press 10 if you want to go to the main menu");
            bool success = int.TryParse(ReadLine(), out int a);
            if (success && a == 0)
            {
                ListOfZones();
                Display2();
            }
            else if (success && a == 10)
            {
                Display();
            }
            else if (success && a == 1)
            {
                DisplayAdamawa();
            }
            else if (success && a == 2)
            {
                DisplayBauchi();
            }
            else if (success && a == 3)
            {
                DisplayBorno();
            }
            else if (success && a == 4)
            {
                DisplayGombe();
            }
            else if (success && a == 5)
            {
                DisplayTaraba();
            }
            else if (success && a == 6)
            {
                DisplayYobe();
            }
            else
            {
                goto wrong;
            }
        }
        static void Display6()
        {
        wrong:
            WriteLine();
            WriteLine("Press The number in front of the state you want to list all of its LGAs");
            WriteLine("Press 0 if you want to go to the previous menu");
            WriteLine("Press 10 if you want to go to the main menu");
            bool success = int.TryParse(ReadLine(), out int a);
            if (success && a == 0)
            {
                ListOfZones();
                Display2();
            }
            else if (success && a == 10)
            {
                Display();
            }
            else if (success && a == 1)
            {
                DisplayJigawa();
            }
            else if (success && a == 2)
            {
                DisplayKaduna();
            }
            else if (success && a == 3)
            {
                DisplayKano();
            }
            else if (success && a == 4)
            {
                DisplayKatsina();
            }
            else if (success && a == 5)
            {
                DisplayKebbi();
            }
            else if (success && a == 6)
            {
                DisplaySokoto();
            }
            else if (success && a == 7)
            {
                DisplayZamfara();
            }
            else
            {
                goto wrong;
            }
         }
        static void Display7()
        {
        notright:
            WriteLine();
            WriteLine("Press The number in front of the state you want to list all of its LGAs");
            WriteLine("Press 0 if you want to go to the previous menu");
            WriteLine("Press 10 if you want to go to the main menu");
            bool success = int.TryParse(ReadLine(), out int a);
            if (success && a == 0)
            {
                ListOfZones();
                Display2();
            }
            else if (success && a == 10)
            {
                Display();
            }
            else if (success && a == 1)
            {
                DisplayAbia();
            }
            else if (success && a == 2)
            {
                DisplayAnambra();
            }
            else if (success && a == 3)
            {
                DisplayEbonyi();
            }
            else if (success && a == 4)
            {
                DisplayEnugu();
            }
            else if (success && a == 5)
            {
                DisplayImo();
            }
            else
            {
                goto notright;
            }
        }
        static void Display9()
        {
        notright:
            WriteLine();
            WriteLine("Press The number in front of the state you want to list all of its LGAs");
            WriteLine("Press 0 if you want to go to the previous menu");
            WriteLine("Press 10 if you want to go to the main menu");
            bool success = int.TryParse(ReadLine(), out int a);
            if (success && a == 0)
            {
                ListOfZones();
                Display2();
            }
            else if (success && a == 10)
            {
                Display();
            }
            else if (success && a == 1)
            {
                DisplayAkwaIbom();
            }
            else if (success && a == 2)
            {
                DisplayBayelsa();
            }
            else if (success && a == 3)
            {
                DisplayCrossRiver();
            }
            else if (success && a == 4)
            {
                DisplayRivers();
            }
            else if (success && a == 5)
            {
                DisplayDelta();
            }
            else if (success && a == 6)
            {
                DisplayEdo();
            }
            else
            {
                goto notright;
            }
        }
        static void Display8()
        {
        notright:
            WriteLine();
            WriteLine("Press The number in front of the state you want to list all of its LGAs");
            WriteLine("Press 0 if you want to go to the previous menu");
            WriteLine("Press 10 if you want to go to the main menu");
            bool success = int.TryParse(ReadLine(), out int a);
            if (success && a == 0)
            {
                ListOfZones();
                Display2();
            }
            else if (success && a == 10)
            {
                Display();
            }
            else if (success && a == 1)
            {
                DisplayEkiti();
            }
            else if (success && a == 2)
            {
                DisplayLagos();
            }
            else if (success && a == 3)
            {
                DisplayOgun();
            }
            else if (success && a == 4)
            {
                DisplayOndo();
            }
            else if (success && a == 5)
            {
                DisplayOsun();
            }
            else if (success && a==6)
            {
                DisplayOyo();
            }
            else
            {
                goto notright;
            }
        }
        static void Display10()
        {
        wrong:
            WriteLine();
            WriteLine("Press The number in front of the state you want to list all of its LGAs then enter");
            WriteLine("Press 0 then enter if you want to go to the previous menu");
            bool success = int.TryParse(ReadLine(), out int a);
            if (success && a == 0)
            {
                Display();

            }
            else if (success && a == 1)
            {
                DisplayAbia();
                
            }
            else if (success && a == 2)
            {
                DisplayAbuja();
            }
            else if (success && a == 3)
            {
                DisplayAdamawa();
            }
            else if (success && a == 4)
            {
                DisplayAkwaIbom();
            }
            else if (success && a == 5)
            {
                DisplayAnambra();
            }
            else if (success && a == 6)
            { 
                DisplayBauchi();
            }
            else if (success && a == 7)
            {
                DisplayBayelsa();
            }
            else if (success && a == 8)
            {
                DisplayBenue();
            }
            else if (success && a == 9)
            {
                DisplayBorno();
            }
            else if (success && a == 10)
            {
                DisplayCrossRiver();
            }
            else if (success && a == 11)
            {
                DisplayDelta();
            }
            else if (success && a == 12)
            {
                DisplayEbonyi();
            }
            else if (success && a == 13)
            {
                DisplayEnugu();
            }
            else if (success && a == 14)
            {
                DisplayEdo();
            }
            else if (success && a == 15)
            {
                DisplayEkiti();
            }
            else if (success && a == 16)
            {
                DisplayGombe();
            }
            else if (success && a == 17)
            {
                DisplayImo();
            }
            else if (success && a == 18)
            {
                DisplayJigawa();
            }
            else if (success && a == 19)
            {
                DisplayKaduna();
            }
            else if (success && a == 20)
            {
                DisplayKano();
            }
            else if (success && a == 21)
            {
                DisplayKatsina();
            }
            else if (success && a == 22)
            {
                DisplayKebbi();
            }
            else if (success && a == 23)
            {
                DisplayKogi();
            }
            else if (success && a == 24)
            {
                DisplayKwara();
            }
            else if (success && a == 25)
            {
                DisplayLagos();
            }
            else if (success && a == 26)
            {
                DisplayNasarawa();
            }
            else if (success && a == 27)
            {
                DisplayNiger();
            }
            else if (success && a == 28)
            {
                DisplayOgun();
            }
            else if (success && a == 29)
            {
                DisplayOndo();
            }
            else if (success && a == 30)
            {
                DisplayOsun();
            }
            else if (success && a == 31)
            {
                DisplayOyo();
            }
            else if (success && a == 32)
            {
                DisplayPlateau();
            }
            else if (success && a == 33)
            {
                DisplayRivers();
            }
            else if (success && a == 34)
            {
                DisplaySokoto();
            }
            else if (success && a == 35)
            {
                DisplayTaraba();
            }
            else if (success && a == 36)
            {
                DisplayYobe();
            }
            else if (success && a == 37)
            {
                DisplayZamfara();
            }
            else
            {
                goto wrong;
            }
        }
        static void DisplayLagos()
        {
            WriteLine();
            WriteLine("Here are all the local governments in Lagos");
            WriteLine(lagos);
        }

        static void DisplayAbuja()
        {
            WriteLine();
            WriteLine("Here are all the local governments in Abuja");
            WriteLine(abuja);
        }
        static void DisplayAbia()
        {
            start:
            WriteLine();
            WriteLine("Here are all the local governments in Abia");
            WriteLine(abia);
            WriteLine();
            WriteLine("Press 11 if you want to go to the Zones menu");
            WriteLine("Press 10 if you want to go to the Main menu");
            bool success = int.TryParse(ReadLine(), out int a);
            if (success && a == 11)
            {
                ListOfZones();
                Display2();
            }
            else if (success && a == 10)
            {
                Display();
            }
            else
            {
                goto start;
            }
        }
        static void DisplayAdamawa()
        {
            start:
            WriteLine();
            WriteLine("Here are all the local governments in Adamawa");
            WriteLine(adamawa);
            WriteLine();
            WriteLine("Press 11 if you want to go to the Zones menu");
            WriteLine("Press 10 if you want to go to the Main menu");
            bool success = int.TryParse(ReadLine(), out int a);
            if (success && a == 11)
            {
                ListOfZones();
                Display2();
            }
            else if (success && a == 10)
            {
                Display();
            }
            else
            {
                goto start;
            }
        }
        static void DisplayAkwaIbom()
        {
            start:
            WriteLine();
            WriteLine("Here are all the local governments in Akwa Ibom");
            WriteLine(akwaibom);
            WriteLine();
            WriteLine("Press 11 if you want to go to the Zones menu");
            WriteLine("Press 10 if you want to go to the Main menu");
            bool success = int.TryParse(ReadLine(), out int a);
            if (success && a == 11)
            {
                ListOfZones();
                Display2();
            }
            else if (success && a == 10)
            {
                Display();
            }
            else
            {
                goto start;
            }
        }
        static void DisplayAnambra()
        {
            start:
            WriteLine();
            WriteLine("Here are all the local governments in Anambra");
            WriteLine(anambra);
            WriteLine();
            WriteLine("Press 11 if you want to go to the Zones menu");
            WriteLine("Press 10 if you want to go to the Main menu");
            bool success = int.TryParse(ReadLine(), out int a);
            if (success && a == 11)
            {
                ListOfZones();
                Display2();
            }
            else if (success && a == 10)
            {
                Display();
            }
            else
            {
                goto start;
            }
        }
        static void DisplayBauchi()
        {
            start:
            WriteLine();
            WriteLine("Here are all the local governments in Bauchi");
            WriteLine(bauchi);
            WriteLine();
            WriteLine("Press 11 if you want to go to the Zones menu");
            WriteLine("Press 10 if you want to go to the Main menu");
            bool success = int.TryParse(ReadLine(), out int a);
            if (success && a == 11)
            {
                ListOfZones();
                Display2();
            }
            else if (success && a == 10)
            {
                Display();
            }
            else
            {
                goto start;
            }
        }
        static void DisplayBayelsa()
        {
            start:
            WriteLine();
            WriteLine("Here are all the local governments in Bayelsa");
            WriteLine(bayelsa);
            WriteLine();
            WriteLine("Press 11 if you want to go to the Zones menu");
            WriteLine("Press 10 if you want to go to the Main menu");
            bool success = int.TryParse(ReadLine(), out int a);
            if (success && a == 11)
            {
                ListOfZones();
                Display2();
            }
            else if (success && a == 10)
            {
                Display();
            }
            else
            {
                goto start;
            }
        }
        static void DisplayBenue()
        {
            start:
            WriteLine();
            WriteLine("Here are all the local governments in Benue");
            WriteLine(benue);
            WriteLine();
            WriteLine("Press 11 if you want to go to the Zones menu");
            WriteLine("Press 10 if you want to go to the Main menu");
            bool success = int.TryParse(ReadLine(), out int a);
            if (success && a == 11)
            {
                ListOfZones();
                Display2();
            }
            else if (success && a == 10)
            {
                Display();
            }
            else
            {
                goto start;
            }
        }
        static void DisplayBorno()
        {
            start:
            WriteLine();
            WriteLine("Here are all the local governments in Borno");
            WriteLine(borno);
            WriteLine();
            WriteLine("Press 11 if you want to go to the Zones menu");
            WriteLine("Press 10 if you want to go to the Main menu");
            bool success = int.TryParse(ReadLine(), out int a);
            if (success && a == 11)
            {
                ListOfZones();
                Display2();
            }
            else if (success && a == 10)
            {
                Display();
            }
            else
            {
                goto start;
            }
        }
        static void DisplayCrossRiver()
        {
            start:
            WriteLine();
            WriteLine("Here are all the local governments in Cross River");
            WriteLine(crossriver);
            WriteLine();
            WriteLine("Press 11 if you want to go to the Zones menu");
            WriteLine("Press 10 if you want to go to the Main menu");
            bool success = int.TryParse(ReadLine(), out int a);
            if (success && a == 11)
            {
                ListOfZones();
                Display2();
            }
            else if (success && a == 10)
            {
                Display();
            }
            else
            {
                goto start;
            }
        }
        static void DisplayDelta()
        {
            start:
            WriteLine();
            WriteLine("Here are all the local governments in Delta");
            WriteLine(delta);
            WriteLine();
            WriteLine("Press 11 if you want to go to the Zones menu");
            WriteLine("Press 10 if you want to go to the Main menu");
            bool success = int.TryParse(ReadLine(), out int a);
            if (success && a == 11)
            {
                ListOfZones();
                Display2();
            }
            else if (success && a == 10)
            {
                Display();
            }
            else
            {
                goto start;
            }
        }
        static void DisplayEbonyi()
        {
            start:
            WriteLine();
            WriteLine("Here are all the local governments in Ebonyi");
            WriteLine(ebonyi);
            WriteLine();
            WriteLine("Press 11 if you want to go to the Zones menu");
            WriteLine("Press 10 if you want to go to the Main menu");
            bool success = int.TryParse(ReadLine(), out int a);
            if (success && a == 11)
            {
                ListOfZones();
                Display2();
            }
            else if (success && a == 10)
            {
                Display();
            }
            else
            {
                goto start;
            }
        }
        static void DisplayEnugu()
        {
            start:
            WriteLine();
            WriteLine("Here are all the local governments in Enugu");
            WriteLine(enugu);
            WriteLine();
            WriteLine("Press 11 if you want to go to the Zones menu");
            WriteLine("Press 10 if you want to go to the Main menu");
            bool success = int.TryParse(ReadLine(), out int a);
            if (success && a == 11)
            {
                ListOfZones();
                Display2();
            }
            else if (success && a == 10)
            {
                Display();
            }
            else
            {
                goto start;
            }
        }
        static void DisplayEdo()
        {
            start:
            WriteLine();
            WriteLine("Here are all the local governments in Edo");
            WriteLine(edo);
            WriteLine();
            WriteLine("Press 11 if you want to go to the Zones menu");
            WriteLine("Press 10 if you want to go to the Main menu");
            bool success = int.TryParse(ReadLine(), out int a);
            if (success && a == 11)
            {
                ListOfZones();
                Display2();
            }
            else if (success && a == 10)
            {
                Display();
            }
            else
            {
                goto start;
            }
        }
        static void DisplayEkiti()
        {
            start:
            WriteLine();
            WriteLine("Here are all the local governments in Ekiti");
            WriteLine(ekiti);
            WriteLine();
            WriteLine("Press 11 if you want to go to the Zones menu");
            WriteLine("Press 10 if you want to go to the Main menu");
            bool success = int.TryParse(ReadLine(), out int a);
            if (success && a == 11)
            {
                ListOfZones();
                Display2();
            }
            else if (success && a == 10)
            {
                Display();
            }
            else
            {
                goto start;
            }
        }
        static void DisplayGombe()
        {
            start:
            WriteLine();
            WriteLine("Here are all the local governments in Gombe");
            WriteLine(gombe);
            WriteLine();
            WriteLine("Press 11 if you want to go to the Zones menu");
            WriteLine("Press 10 if you want to go to the Main menu");
            bool success = int.TryParse(ReadLine(), out int a);
            if (success && a == 11)
            {
                ListOfZones();
                Display2();
            }
            else if (success && a == 10)
            {
                Display();
            }
            else
            {
                goto start;
            }
        }
        static void DisplayImo()
        {
            start:
            WriteLine();
            WriteLine("Here are all the local governments in Imo");
            WriteLine(imo);
            WriteLine();
            WriteLine("Press 11 if you want to go to the Zones menu");
            WriteLine("Press 10 if you want to go to the Main menu");
            bool success = int.TryParse(ReadLine(), out int a);
            if (success && a == 11)
            {
                ListOfZones();
                Display2();
            }
            else if (success && a == 10)
            {
                Display();
            }
            else
            {
                goto start;
            }
        }
        static void DisplayJigawa()
        {
            start:
            WriteLine();
            WriteLine("Here are all the local governments in Jigawa");
            WriteLine(jigawa);
            WriteLine();
            WriteLine("Press 11 if you want to go to the Zones menu");
            WriteLine("Press 10 if you want to go to the Main menu");
            bool success = int.TryParse(ReadLine(), out int a);
            if (success && a == 11)
            {
                ListOfZones();
                Display2();
            }
            else if (success && a == 10)
            {
                Display();
            }
            else
            {
                goto start;
            }
        }
        static void DisplayKaduna()
        {
            start:
            WriteLine();
            WriteLine("Here are all the local governments in Kaduna");
            WriteLine(kaduna);
            WriteLine();
            WriteLine("Press 11 if you want to go to the Zones menu");
            WriteLine("Press 10 if you want to go to the Main menu");
            bool success = int.TryParse(ReadLine(), out int a);
            if (success && a == 11)
            {
                ListOfZones();
                Display2();
            }
            else if (success && a == 10)
            {
                Display();
            }
            else
            {
                goto start;
            }
        }
        static void DisplayKano()
        {
            start:
            WriteLine();
            WriteLine("Here are all the local governments in Kano");
            WriteLine(kano);
            WriteLine();
            WriteLine("Press 11 if you want to go to the Zones menu");
            WriteLine("Press 10 if you want to go to the Main menu");
            bool success = int.TryParse(ReadLine(), out int a);
            if (success && a == 11)
            {
                ListOfZones();
                Display2();
            }
            else if (success && a == 10)
            {
                Display();
            }
            else
            {
                goto start;
            }
        }
        static void DisplayKatsina()
        {
            start:
            WriteLine();
            WriteLine("Here are all the local governments in Katsina");
            WriteLine(katsina);
            WriteLine();
            WriteLine("Press 11 if you want to go to the Zones menu");
            WriteLine("Press 10 if you want to go to the Main menu");
            bool success = int.TryParse(ReadLine(), out int a);
            if (success && a == 11)
            {
                ListOfZones();
                Display2();
            }
            else if (success && a == 10)
            {
                Display();
            }
            else
            {
                goto start;
            }
        }
        static void DisplayKebbi()
        {
            start:
            WriteLine();
            WriteLine("Here are all the local governments in Kebbi");
            WriteLine(kebbi);
            WriteLine();
            WriteLine("Press 11 if you want to go to the Zones menu");
            WriteLine("Press 10 if you want to go to the Main menu");
            bool success = int.TryParse(ReadLine(), out int a);
            if (success && a == 11)
            {
                ListOfZones();
                Display2();
            }
            else if (success && a == 10)
            {
                Display();
            }
            else
            {
                goto start;
            }
        }
        static void DisplayKogi()
        {
            start:
            WriteLine();
            WriteLine("Here are all the local governments in Kogi");
            WriteLine(kogi);
            WriteLine();
            WriteLine("Press 11 if you want to go to the Zones menu");
            WriteLine("Press 10 if you want to go to the Main menu");
            bool success = int.TryParse(ReadLine(), out int a);
            if (success && a == 11)
            {
                ListOfZones();
                Display2();
            }
            else if (success && a == 10)
            {
                Display();
            }
            else
            {
                goto start;
            }
        }
        static void DisplayKwara()
        {
            start:
            WriteLine();
            WriteLine("Here are all the local governments in Kwara");
            WriteLine(kwara);
            WriteLine();
            WriteLine("Press 11 if you want to go to the Zones menu");
            WriteLine("Press 10 if you want to go to the Main menu");
            bool success = int.TryParse(ReadLine(), out int a);
            if (success && a == 11)
            {
                ListOfZones();
                Display2();
            }
            else if (success && a == 10)
            {
                Display();
            }
            else
            {
                goto start;
            }
        }
        static void DisplayNasarawa()
        {
            start:
            WriteLine();
            WriteLine("Here are all the local governments in Nasarawa");
            WriteLine(nasarawa);
            WriteLine();
            WriteLine("Press 11 if you want to go to the Zones menu");
            WriteLine("Press 10 if you want to go to the Main menu");
            bool success = int.TryParse(ReadLine(), out int a);
            if (success && a == 11)
            {
                ListOfZones();
                Display2();
            }
            else if (success && a == 10)
            {
                Display();
            }
            else
            {
                goto start;
            }
        }
        static void DisplayNiger()
        {
            start:
            WriteLine();
            WriteLine("Here are all the local governments in Niger");
            WriteLine(niger);
            WriteLine();
            WriteLine("Press 11 if you want to go to the Zones menu");
            WriteLine("Press 10 if you want to go to the Main menu");
            bool success = int.TryParse(ReadLine(), out int a);
            if (success && a == 11)
            {
                ListOfZones();
                Display2();
            }
            else if (success && a == 10)
            {
                Display();
            }
            else
            {
                goto start;
            }
        }
        static void DisplayOgun()
        {
            start:
            WriteLine();
            WriteLine("Here are all the local governments in Ogun");
            WriteLine(ogun);
            WriteLine();
            WriteLine("Press 11 if you want to go to the Zones menu");
            WriteLine("Press 10 if you want to go to the Main menu");
            bool success = int.TryParse(ReadLine(), out int a);
            if (success && a == 11)
            {
                ListOfZones();
                Display2();
            }
            else if (success && a == 10)
            {
                Display();
            }
            else
            {
                goto start;
            }
        }
        static void DisplayOndo()
        {
            start:
            WriteLine();
            WriteLine("Here are all the local governments in Ondo");
            WriteLine(ondo);
            WriteLine();
            WriteLine("Press 11 if you want to go to the Zones menu");
            WriteLine("Press 10 if you want to go to the Main menu");
            bool success = int.TryParse(ReadLine(), out int a);
            if (success && a == 11)
            {
                ListOfZones();
                Display2();
            }
            else if (success && a == 10)
            {
                Display();
            }
            else
            {
                goto start;
            }
        }
        static void DisplayOsun()
        {
            start:
            WriteLine();
            WriteLine("Here are all the local governments in Lagos");
            WriteLine(osun);
            WriteLine();
            WriteLine("Press 11 if you want to go to the Zones menu");
            WriteLine("Press 10 if you want to go to the Main menu");
            bool success = int.TryParse(ReadLine(), out int a);
            if (success && a == 11)
            {
                ListOfZones();
                Display2();
            }
            else if (success && a == 10)
            {
                Display();
            }
            else
            {
                goto start;
            }
        }
        static void DisplayOyo()
        {
            start:
            WriteLine();
            WriteLine("Here are all the local governments in Lagos");
            WriteLine(oyo);
            WriteLine();
            WriteLine("Press 11 if you want to go to the Zones menu");
            WriteLine("Press 10 if you want to go to the Main menu");
            bool success = int.TryParse(ReadLine(), out int a);
            if (success && a == 11)
            {
                ListOfZones();
                Display2();
            }
            else if (success && a == 10)
            {
                Display();
            }
            else
            {
                goto start;
            }
        }
        static void DisplayPlateau()
        {
            start:
            WriteLine();
            WriteLine("Here are all the local governments in Plateau");
            WriteLine(plateau);
            WriteLine();
            WriteLine("Press 11 if you want to go to the Zones menu");
            WriteLine("Press 10 if you want to go to the Main menu");
            bool success = int.TryParse(ReadLine(), out int a);
            if (success && a == 11)
            {
                ListOfZones();
                Display2();
            }
            else if (success && a == 10)
            {
                Display();
            }
            else
            {
                goto start;
            }
        }
        static void DisplayRivers()
        {
            start:
            WriteLine();
            WriteLine("Here are all the local governments in Rivers");
            WriteLine(rivers);
            WriteLine();
            WriteLine("Press 11 if you want to go to the Zones menu");
            WriteLine("Press 10 if you want to go to the Main menu");
            bool success = int.TryParse(ReadLine(), out int a);
            if (success && a == 11)
            {
                ListOfZones();
                Display2();
            }
            else if (success && a == 10)
            {
                Display();
            }
            else
            {
                goto start;
            }
        }
        static void DisplaySokoto()
        {
            start:
            WriteLine();
            WriteLine("Here are all the local governments in Sokoto");
            WriteLine(sokoto);
            WriteLine();
            WriteLine("Press 11 if you want to go to the Zones menu");
            WriteLine("Press 10 if you want to go to the Main menu");
            bool success = int.TryParse(ReadLine(), out int a);
            if (success && a == 11)
            {
                ListOfZones();
                Display2();
            }
            else if (success && a == 10)
            {
                Display();
            }
            else
            {
                goto start;
            }
        }
        static void DisplayTaraba()
        {
            start:
            WriteLine();
            WriteLine("Here are all the local governments in Taraba");
            WriteLine(taraba);
            WriteLine();
            WriteLine("Press 11 if you want to go to the Zones menu");
            WriteLine("Press 10 if you want to go to the Main menu");
            bool success = int.TryParse(ReadLine(), out int a);
            if (success && a == 11)
            {
                ListOfZones();
                Display2();
            }
            else if (success && a == 10)
            {
                Display();
            }
            else
            {
                goto start;
            }
        }
        static void DisplayYobe()
        {
            start:
            WriteLine();
            WriteLine("Here are all the local governments in Yobe");
            WriteLine(yobe);
            WriteLine();
            WriteLine("Press 11 if you want to go to the Zones menu");
            WriteLine("Press 10 if you want to go to the Main menu");
            bool success = int.TryParse(ReadLine(), out int a);
            if (success && a == 11)
            {
                ListOfZones();
                Display2();
            }
            else if (success && a == 10)
            {
                Display();
            }
            else
            {
                goto start;
            }
        }
        static void DisplayZamfara()
        {
            start:
            WriteLine();
            WriteLine("Here are all the local governments in Zamfara");
            WriteLine(zamfara);
            WriteLine();
            WriteLine("Press 11 if you want to go to the Zones menu");
            WriteLine("Press 10 if you want to go to the Main menu");
            bool success = int.TryParse(ReadLine(), out int a);
            if (success && a == 11)
            {
                ListOfZones();
                Display2();
            }
            else if (success && a == 10)
            {
                Display();
            }
            else
            {
                goto start;
            }
        }

        static string[] ListOfStates()
        {
            WriteLine();
            WriteLine("Here are all the States");
            string[] states = {"",
                                    "1.  ABIA",
                                    "2.  ABUJA, FCT",
                                    "3.  ADAMAWA",
                                    "4.  AKWA IBOM",
                                    "5.  ANAMBRA",
                                    "6.  BAUCHI",
                                    "7.  BAYELSA",
                                    "8.  BENUE",
                                    "9.  BORNO",
                                    "10. CROSS RIVER",
                                    "11. DELTA",
                                    "12. EBONYI",
                                    "13. ENUGU",
                                    "14. EDO",
                                    "15. EKITI",
                                    "16. GOMBE",
                                    "17. IMO",
                                    "18. JIGAWA",
                                    "19. KADUNA",
                                    "20. KANO",
                                    "21. KATSINA",
                                    "22. KEBBI",
                                    "23. KOGI",
                                    "24. KWARA",
                                    "25. LAGOS",
                                    "26. NASARAWA",
                                    "27. NIGER",
                                    "28. OGUN",
                                    "29. ONDO",
                                    "30. OSUN",
                                    "31. OYO",
                                    "32. PLATEAU",
                                    "33. RIVERS",
                                    "34. SOKOTO",
                                    "35. TARABA",
                                    "36. YOBE",
                                    "37. ZAMFARA",
            };
         
                 if (states.Length > 0)
                {
                    foreach (string item in states)
                    {
                        WriteLine($"{item.Trim().ToUpper()}");
                    }
                 }
            return states;
        }
        static string[] ListOfZones()
        {
            WriteLine();
            WriteLine("Here are all the Zones");
            string[] zones =
            {
                                "",
                                "1. NORTH CENTRAL",
                                "2. NORTH EAST",
                                "3. NORTH WEST",
                                "4. SOUTH EAST",
                                "5. SOUTH SOUTH",
                                "6. SOUTH WEST",
            };
            if (zones.Length > 0)
            {
                foreach (string item in zones)
                {
                    WriteLine($"{item.Trim().ToUpper()}");
                }
            }
            return zones;
        }
        static string[] NorthCentral()
        {
            string[] nc =
            {
                                "1. BENUE",
                                "2. KOGI",
                                "3. KWARA",
                                "4. NASARAWA",
                                "5. NIGER",
                                "6. PLATEAU",
                                "7. ABUJA",
            };
            if (nc.Length > 0)
            {
                foreach (string item in nc)
                {
                    WriteLine($"{item.Trim().ToUpper()}");
                }
            }
            return nc;
        }
        static string[] NorthEast()
        {
            string[] ne =
            {
                                "1. ADAMAWA",
                                "2. BAUCHI",
                                "3. BORNO",
                                "4. GOMBE",
                                "5. TARABA",
                                "6. YOBE"
            };
            if (ne.Length > 0)
            {
                foreach (string item in ne)
                {
                    WriteLine($"{item.Trim().ToUpper()}");
                }
            }
            return ne;
        }
        static string[] NorthWest()
        {
            string[] nw =
            {
                                "1. JIGAWA",
                                "2. KADUNA",
                                "3. KANO",
                                "4. KATSINA",
                                "5. KEBBI",
                                "6. SOKOTO",
                                "7. ZAMFARA",
            };
            if (nw.Length > 0)
            {
                foreach (string item in nw)
                {
                    WriteLine($"{item.Trim().ToUpper()}");
                }
            }
            return nw;
        }
        static string[] SouthEast()
        {
            string[] se =
            {
                                "1. ABIA",
                                "2. ANAMBRA",
                                "3. EBONYI",
                                "4. ENUGU",
                                "5. IMO",
            };
            if (se.Length > 0)
            {
                foreach (string item in se)
                {
                    WriteLine($"{item.Trim().ToUpper()}");
                }
            }
            return se;
        }
        static string[] SouthWest()
        {
            string[] sw =
            {
                               
                                "1. EKITI",
                                "2. LAGOS",
                                "3. OGUN",
                                "4. ONDO",
                                "5. OSUN",
                                "6. OYO",
            };
            if (sw.Length > 0)
            {
                foreach (string item in sw)
                {
                    WriteLine($"{item.Trim().ToUpper()}");
                }
            }
            return sw;
        }
        static string[] SouthSouth()
        {
            string[] ss =
            {
                                "1. AKWA IBOM",
                                "2. BAYELSA",
                                "3. CROSS RIVER",
                                "4. RIVERS",
                                "5. DELTA",
                                "6. EDO",
            };
            if (ss.Length > 0)
            {
                foreach (string item in ss)
                {
                    WriteLine($"{item.Trim().ToUpper()}");
                }
            }
            return ss;
        }
    }
}
