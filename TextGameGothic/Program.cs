using tekstgra;

internal class Program
{
    public static Player currentPlayer = new Player();
    private static void Main()
    {
        Start();
    }
    static void Start()

    {
        Console.WriteLine("Witaj w tekstowym Goticzku");
        Console.WriteLine("Zabieram Cię skazańcze na podróż po górniczej dolinie");
        Console.WriteLine("Będzie to mocno skrócona historia w lekko humorystycznym wydaniu");
        Console.WriteLine("Więc rób kucyka z włosów i wskakuj w szarą piżamę");
        Console.WriteLine("Zaczynamy!!!");
        Console.WriteLine("Naciskaj ENTER aby przejść dalej");
        Console.ReadLine();
        Console.Clear();
        Console.WriteLine("Na początku szybka instrukcja");
        Console.WriteLine("Główną fabułę przeklikujemy ENTEREM");
        Console.WriteLine("Gdy będzie możliwość wyboru z prośbą o wprowadzenie słowa będzie to oznaczone znakiem '>'");
        Console.WriteLine("Słowa należy wpisywać z małej litery, tak jak będą wprowadzone w pytaniu");
        Console.WriteLine("Gdy błędnie wpiszesz słowo, gra przejdzie dalej a Ty stracisz możliwość rozwoju postaci");
        Console.WriteLine("Koniec instrukcji, miłej zabawy ");
        Console.ReadLine();
        Console.Clear();
        Console.WriteLine("Królestwo Myrtany, Robar i tak dalej...");
        Console.WriteLine("Orkowie atakują, świetny pomysł na więzienie z kopalnią i bariera");
        Console.WriteLine("- Królu mam dobrą i złą wiadomość");
        Console.WriteLine("- Zacznij od złej");
        Console.WriteLine("- Nie mamy władzy nad kopalnią, wszystkich strażników zabili skazańcy");
        Console.WriteLine("- Hmmm... A dobra ");
        Console.WriteLine("- Wyczarowaliśmy ją, bariera jest nawet za duża przez co straciliśmy i magów");
        Console.WriteLine("- Nareszcie !!!  Jak to nie mamy władzy?! Jak to nie żyją ?!");
        Console.ReadLine();
        Console.Clear();
        Console.WriteLine("Nasz skazaniec zostaje przyprowadzony na klif z którego ma trafić za barierę");
        Console.WriteLine("Podczas przemowy sędziego przychodzi mag ognia z listem który mamy dostarczyć dla magów uwięzionych za barierą");
        Console.WriteLine("Bierzesz list i oszczędzają Ci reszty paplaniny");
        Console.WriteLine("Spadanie w dół z okrzykiem");
        Console.WriteLine("Miły Pan mówi że wita w kolonii");
        Console.BackgroundColor = ConsoleColor.Red;
        Console.WriteLine("Spotkanie pięści oprawcy z twarzą bohatera");
        Console.WriteLine("Ała, ała, ała");
        Console.BackgroundColor = ConsoleColor.Black;
        Console.WriteLine("- Zostawcie go!!!");
        Console.WriteLine("Od razu słychać że ktoś ważny Ci pomaga bo oprawcy uciekają bardzo szybko");
        Console.WriteLine("Uratowany przez typa co wygląda jak Meksykanin z wielkim łukiem");
        Console.WriteLine("- Nazywam się Diego - powiedział wąsaty Meksykanin");
        Console.WriteLine("- ja nazywam się...");
        Console.WriteLine("- Nie obchodzi mnie kim jesteś!!");
        Console.WriteLine("Na twarzy naszego skazańca pojawiła się smutna mina");
        Console.WriteLine("Diego mówi że są 3 obozy i że jego jest blisko i spoko, że jest etat na ciecia czy cienia");
        Console.WriteLine("Inne obozy to sekta i złodzieje, więc on sobie idzie i będzie na nas czekał w obozie");
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("Ty chwilę się rozglądasz po okolicy znajdujesz trochę jedzenia i piwo");
        Console.WriteLine("Idąc w stronę obozu znajdujesz zniszczoną i opuszczoną kopalnie");
        Console.WriteLine("Czy zbadasz kopalnie i jej okolice czy idziesz do obozu ?");
        Console.WriteLine("Jeśli chcesz wybrać 1 opcje napisz kopalnia, jeśli wybierasz 2 opcje napisz oboz");
        Console.Write("> ");
        string pierwszyWybor = Console.ReadLine();
        if (pierwszyWybor == "kopalnia")
        {
            Console.WriteLine("znajdujesz skrzynkę, w niej jest zardzewiały miecz");
            Console.WriteLine("zabierasz miecz i wracasz na drogę do obozu");
            currentPlayer.damage += 4;
            Console.WriteLine("Twoje obrażenia zostają zwiększone o 4 pt i obecnie wynoszą " + currentPlayer.damage + "pt ");
            Console.WriteLine("W doradzę do obozu poznajesz kilku ludzi których już więcej nie zobaczysz");
            Console.WriteLine("Dowiadujesz się od nich że najważniejsze by ścierwojad nie dziabnął Cię pierwszy");

        }
        else if (pierwszyWybor == "oboz")
        {
            Console.WriteLine("W doradzę do obozu poznajesz kilku ludzi których już więcej nie zobaczysz");
            Console.WriteLine("Dowiadujesz się od nich że najważniejsze by ścierwojad nie dziabnął Cię pierwszy");
        }
        else
        {
            Console.WriteLine("ŹLE PISZESZ");

        }

        Console.WriteLine("Wchodzisz główną bramą obozu, bo masz ziomka Diego");
        Console.WriteLine("Idąc bujasz się na boki, ramiona szeroko jak byś beczki pod nimi niósł");
        Console.WriteLine("Przecież jesteś u siebie, wszędzie same ziomeczki");
        Console.WriteLine("Lecisz na zamek!!! Na imprezę z magami, fajerwerki z fajerboli !!!");
        Console.WriteLine("Przy bramie zamku dowiadujesz się że każdy zna Meksykanina i wcale nie jest tu taki ważny");
        Console.WriteLine("Za imprezę na zamku chcą 1000 bryłek rudy");
        Console.WriteLine("ALBO");
        Console.WriteLine("Musisz zostać ich cieciem");
        Console.WriteLine("Słabiutko... ");
        Console.WriteLine("Przy bramie poznajesz fanatyka bram, Thorusa");
        Console.WriteLine("Twierdzi że zawsze przy jakieś będzie, to jego przeznaczenie");
        Console.WriteLine("Odchodzisz, będziesz musiał robić za ciecia by oddać ten list, może w końcu nie będziesz najbiedniejszy pod barierą");
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("Diego siedzi obok, pytasz się o ten etat na ciecia");
        Console.WriteLine("Okazuje się ze rekrutacja do tej firmy składa się z 5 etapów");
        Console.WriteLine("Do tego bez umowy... Janusze biznesu są nawet tu");
        Console.WriteLine("Diego mówi Ci gdzie iść, z kim rozmawiać, kto się liczy");
        Console.WriteLine("Najpierw idziesz do Rączki bo ręka rękę myje");
        Console.WriteLine("Po drodze wpadły Ci kamyki do butów, ale ambicje rozwoju są najważniejsze");
        Console.WriteLine("Idziesz teraz na palcach, nie liczy się ból");
        Console.WriteLine("Na Twój widok Rączka od razu był zadowolony");
        Console.WriteLine("Twierdzi że jest z Tobą bo w obozie przydadzą się dobrzy złodzieje");
        Console.WriteLine("Co tu się stało?");
        Console.WriteLine("Łatwo poszło, idziemy dalej, ale już bez kamyczków");
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("Idziemy do Świstaka, z nadzieją że nie będzie zawijał w sreberko");
        Console.WriteLine("Proste zadanie");
        Console.WriteLine("Świstak mówi że chce błyszczący się miecz");
        Console.WriteLine("Jego kolega ma taki ale się z nim pokłócił i mu nie da");
        Console.WriteLine("Dostaniemy kasę na błyskotkę ale nie możemy mówić że to dla niego");
        Console.WriteLine("Bierzesz 100 i w drogę !!!");
        Console.WriteLine("Na targu od razu widzisz który spełnia opis sprzedawcy");
        Console.WriteLine("Ma ten mieczyk i nam go sprzeda za 110 bryłek");
        Console.WriteLine("Mówisz mu ze zaraz wracasz");
        Console.WriteLine("puk puk w norkę Świstaka");
        Console.WriteLine("Czy jest tu jakiś Świstak? To daj dyszkę");
        Console.WriteLine("Kupujesz tą zabawkę i znów do Świstaka");
        Console.WriteLine("Już też jest za Tobą");
        Console.WriteLine("Idziesz do następnego");
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("A skoro nie idzie tak źle to idziesz do Złego");
        Console.WriteLine("O dziwo nie jest taki zły");
        Console.WriteLine("Musisz znaleźć kolegę co długo nie wraca");
        Console.WriteLine("W końcu jakieś wyzwanie");
        Console.WriteLine("Idziesz pogadać z osobą co zastępuje zaginionego");
        Console.WriteLine("Po drodze widzisz grubaska co coś gotuje");
        Console.WriteLine("A jako że w więzieniu za dobrze nie karmili czyli wcale to postanawiasz zagadać");
        Console.WriteLine("Dostajesz pełną miskę na dzień dobry");
        Console.WriteLine("Mmmm potrawka z chrząszcza, mogę ją jeść bez końca");
        Console.WriteLine("-Jak chcesz więcej to przynieś grzyby, one poprawiają smak");
        Console.WriteLine("Dostajesz historię że ktoś poszedł po grzybki i nie wrócił");
        Console.WriteLine("Co za zbieg okoliczności");
        Console.WriteLine("Idziesz po grzybki, wiesz gdzie znajdziesz zaginionego ");
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("Idziesz w miejsce gdzie są grzybki, widzisz jaskinie a w niej kretoszczury i jakiś materiał");
        Console.WriteLine("Zbierasz wszystkie grzyby i biegniesz się do jaskini");
        Console.WriteLine("Kretoszczury nawet nie zauważyły");
        Console.WriteLine("Znajdziesz tam ciało");
        Console.WriteLine("Ma amulet z napisem NEK");
        Console.WriteLine("To ta osoba co miałeś znaleźć");
        Console.WriteLine("Wracasz przekazać smutną nowinę, po drodze zostawiasz grzyby");
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("Kierujesz się do Złego by dać mu amulet przyjaciela");
        Console.WriteLine("Zły stwierdził że też jest za Tobą");
        Console.WriteLine("Po smutku czas rozładować emocje, idziesz do Scatiego");
        Console.WriteLine("Dostajesz informację, że musisz wygrać walkę na arenie");
        Console.WriteLine("Tylko nikt się nie bije na jego arenie");
        Console.WriteLine("Czas kogoś wyzwać");
        Console.WriteLine("Widzisz 3 wojowników");
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("Próbujesz z osobnikiem w ubraniu ciecia");
        Console.WriteLine("Nie chce walczyć, ale proponuje napić się razem");
        Console.WriteLine("Chwilę rozmawiacie, po czym zgadza się na przyjacielski sparing");
        Console.WriteLine("Wygrywasz, chyba kolega się trochę podłożył");
        Console.WriteLine("Czas na kolejną próbę z kolejnym zawodnikiem");
        Console.WriteLine("Jest z innego obozu, jest najsilniejszy i też nie chce walczyć");
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("Postanawiasz rozwiązać ten problem obrażając go.");
        Console.WriteLine("-Z początku chciałem powiedzieć coś o twoich wątłych ramionach, ale potem zobaczyłem twoją paskudną mordę!");
        Console.WriteLine("-Pomyślmy… Nie, nie przychodzi mi do głowy nic, co byłbyś w stanie zrozumieć.");
        Console.WriteLine("-Twój ojciec zabawiał się z owcami!");
        Console.WriteLine("Wszystkie Twoje argumenty nie skutkują więc mówisz armatę");
        Console.WriteLine("Powiedzmy sobie szczerze – przyszedłeś tutaj tylko dlatego, żeby móc pocałować Gomeza w d*pę!");
        Console.WriteLine("Zrobił się cały czerwony");
        Console.WriteLine("Zaczął krzyczeć i rzucać mięsem, że zabrakło mu tchu i upadł nieprzytomny");
        Console.WriteLine("Tak zostałeś najlepszym wojownikiem");
        Console.WriteLine("Najlepsi przyjaciele z Scattym");
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("Po dzisiejszych przygodach postanawiasz przespać się w opuszczonej chacie");
        Console.WriteLine("Budzisz się wypoczęty");
        currentPlayer.health += 10;
        Console.WriteLine("Twoje życko zregenerowało się i wynosi " + currentPlayer.health);
        Console.WriteLine("Wracasz do Thorusa, może się zlituje");
        Console.WriteLine("Po długich negocjacjach powiedział, że jak zostanę jego killerem to się za mną wstawi");
        Console.WriteLine("Poszukiwania celu trwają");
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("Znajdujesz cel w podanej przez Thorusa lokalizacji");
        Console.WriteLine("Krótka rozmowa by mieć pewność że to ten");
        Console.WriteLine("To on, ale zaproponował Ci spacer do jego obozu");
        Console.WriteLine("Co masz do stracenia, czas poznać nowy obóz");
        Console.WriteLine("Podczas podróży pomiędzy obozami atakuje was ścierwojad");
        Console.WriteLine("Razem atakujecie");
        Console.WriteLine("Wasza siła ataku wynosi " + (currentPlayer.damage * 2));
        currentPlayer.damage *= 2;
        Console.ReadKey();
        Encounters.NaukaWalki();
        Console.ReadKey();
        Console.Clear();
        currentPlayer.damage /= 2;
        Console.WriteLine("Po walce siła ataku wraca do " + currentPlayer.damage);
        Console.WriteLine("Dostajecie się do nowego obozu");
        Console.WriteLine("Tak nazywa się ten obóz, nowy obóz");
        Console.WriteLine("Twój cel mówi że już więcej nie wróci do miejsca waszego spotkania");
        Console.WriteLine("Już czujesz rosnący szacunek");
        Console.WriteLine("Sprawdzasz co Nowy obóz ma Ci do zaoferowania");
        Console.WriteLine("Okazuje się że w zasadzie to taki sam Januszex jak u Gomeza w starym obozie");
        Console.WriteLine("Tylko ruda zostaje w kopcu a nie jest sprzedawana u króla");
        Console.WriteLine("Więc bieda aż piszczy");
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("Litujesz się nad biedakami i postanawiasz im pomóc w kilku sprawach");
        Console.WriteLine("Okazuje się że mają bardzo dobry program przydziału mieszkań");
        Console.WriteLine("By dostać domek, wystarczy kogoś pokonać");
        Console.WriteLine("Nowy kolega Gorn przy ognisku to wszytko Ci powiedział");
        Console.WriteLine("Polubiłeś typa");
        Console.WriteLine("Zdobyłeś nowe mieszkanie na wynajem");
        Console.WriteLine("Dostałeś też info że trzeba zabić jaszczurkę bo im tamę niszczy");
        Console.WriteLine("Rozdeptałeś ją");
        Console.WriteLine("Dostałeś za ten trud troszkę rudy i ryżówkę");
        currentPlayer.coins += 100;
        currentPlayer.potion += 1;
        Console.WriteLine("Obecnie masz " + currentPlayer.coins + " bryłek i " + currentPlayer.potion + " potek");
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("W obozie znajdujesz łysego z tatuażami na twarzy");
        Console.WriteLine("Dostajesz propozycję pracy jako kurier");
        Console.WriteLine("Musisz rozprowadzić po obozie papierosy z bagiennego ziela");
        Console.WriteLine("Szybko roznosisz towar, łysek proponuje Ci że wstawi się za Tobą u swoich");
        Console.WriteLine("Dostałeś też mocnego papierosa dla jednego z ich magów na głównym placu");
        Console.WriteLine("Tam Cię jeszcze nie było, więc dostajesz info że jest jeszcze kilka łysych w starym obozie");
        Console.WriteLine("Któryś Cię zaprowadzi, na wejście dostaniesz 3 takie papierosy i tak każdego dnia");
        Console.WriteLine("Wracasz do starego obozu jakby sam Beliar Cię gonił");
        Console.WriteLine("Odnajdujesz osoby po odbiciach światła z ich łysej głowy");
        Console.WriteLine("Ruszasz na wyprawę do nowego miejsca");
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("Wszędzie bagno");
        Console.WriteLine("Wilgoć i pleśń wszędzie");
        Console.WriteLine("Nic dziwnego że mają takie wizje");
        Console.WriteLine("Na wejściu rozmawiasz ze skinheadem Lesterem");
        Console.WriteLine("Objaśnia Ci że tutejsi magowie mają swoje zasady");
        Console.WriteLine("Jak oni się do Ciebie nie odezwą to nic do nich nie mów");
        Console.WriteLine("I że jak coś to pomoże z tym który jest obok");
        Console.WriteLine("Kolejnym razem masz przyjść i krzyczeć że w śnie miałeś wizje z ich bóstwem");
        Console.WriteLine("Dostajesz też info gdzie za darmo rozdają skręty, Twój kolejny przystanek");
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("Zwiedzasz obóz, pomagasz im wypalić ich ziele, dla ich dobra");
        Console.WriteLine("Słowotok wychodzi z Ciebie, opowiadasz nowicjuszowi tyle że aż zasnął");
        Console.WriteLine("Bardzo spodobało się to jednemu magowi");
        Console.WriteLine("Twierdzi, że twoja moc magiczna jest silna");
        Console.WriteLine("Czas dalej zwiedzać");
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("Przypomina Ci się że masz specjalnego papierosa dla maga na głównym placu");
        Console.WriteLine("Idziesz do wybrańca");
        Console.WriteLine("3maj, only 4U");
        Console.WriteLine("Wypalił całego za jednym pociągnięciem");
        Console.WriteLine("Upadł na ziemię");
        Console.WriteLine("Chyba nie wytrzymał, będzie problem");
        Console.WriteLine("Nie chcesz marnować czasu, więc idziesz jak najdalej");
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("Uciekając od miejsca zbrodni znalazłeś miejsce produkcji");
        Console.WriteLine("To w tym miejscu ciężką pracą nowicjuszy robione są lokalne wyroby");
        Console.WriteLine("Jeden z nich odstaje od reszty");
        Console.WriteLine("Bardzo wolno pracuje");
        Console.WriteLine("Okazuje się że ma dla Ciebie misje");
        Console.WriteLine("Prosi byś poszedł do miejsca gdzie rozdają dzienną porcje");
        Console.WriteLine("Tam będzie leżał jego zmiennik a nie przyszedł już od dawana");
        Console.WriteLine("Udajesz się w to miejsce");
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("Udało Ci się zastraszyć nieroba");
        Console.WriteLine("Idzie do swojej pracy");
        Console.WriteLine("Wróciłeś na miejsce by sprawdzić czy wszytko jest na miejscu");
        Console.WriteLine("Mag który pilnował nowicjuszy przemówił, jaki Ty dobry jesteś");
        Console.WriteLine("Ale możesz być lepszy, leć na bagna i pogoń zbieraczy");
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("Na miejscu okazuje się że dobrze zbierają");
        Console.WriteLine("Tylko wyrośnięte komary przeszkadzają");
        Console.WriteLine("Musisz zniszczyć krwiopijce");
        Encounters.PierwszeSpotkanie();
        Console.Clear();
        Console.WriteLine("Zabiłeś stwora");
        Console.WriteLine("Już zbieracze są bezpieczni");
        Console.WriteLine("Wracasz do maga, ten Cię bardzo polubił");
        Console.WriteLine("Mówi że będzie za wstąpieniem bohatera do ich bractwa");
        Console.WriteLine("Robi się już późno, wracasz do miejsca rozdawania skrętów i tam idziesz spać");
        Console.WriteLine("Rano przypominasz sobie słowa tego Lestera spod bramy");
        Console.WriteLine("Wracasz poszerzać znajomości wśród magów");
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("Gdy tylko zobaczyłeś słońce odbijające się od ich łysych głów zacząłeś swój teatr");
        Console.WriteLine("Opowiadałeś Lesterowi krzycząc jak to śpiący w śnie przyszedł na herbatkę");
        Console.WriteLine("Po 2h wymyślania kończy Ci się wena");
        Console.WriteLine("Mag obok stwierdził, że nikt takich wizji jeszcze nie miał i muszę być wybrańcem");
        Console.WriteLine("Stwierdził że jest za Tobą, tylko masz mu opowiadać kolejne takie wizje");
        Console.WriteLine("Znów robi się ciemno");
        Console.WriteLine("Możesz jeszcze ruszyć na małego expa lub iść spać");
        Console.WriteLine("Jeśli chcesz wybrać 1 opcje napisz exp, jeśli wybierasz 2 opcje napisz spanko");
        Console.Write("> ");
        string drugiWybor = Console.ReadLine();
        if (drugiWybor == "exp")
        {
            Encounters.LosowaWalka();
            Console.WriteLine("Po wygranej walce czujesz się zmęczony");
            Console.WriteLine("Dzięki walce stajesz się silniejszy");
            currentPlayer.damage += 8;
            Console.WriteLine("Twoje obrażenia zostają zwiększone o 8 pt i obecnie wynoszą " + currentPlayer.damage + "pt ");
            Console.WriteLine("Po walce wracasz do obozu");
            Console.WriteLine("Idziesz w swoje miejsce przy darmowych skrętach do śpiulkolotu");

        }
        else if (drugiWybor == "spanko")
        {
            Console.WriteLine("Idziesz w swoje miejsce przy darmowych skrętach do śpiulkolotu");
        }
        else
        {
            Console.WriteLine("ŹLE PISZESZ");

        }

        Console.ReadKey();
        Console.Clear();
        currentPlayer.health += 10;
        Console.WriteLine("Twoje życie zostało odnowione i wynosi " + currentPlayer.health);
        Console.WriteLine("Wstajesz nowy dzień a wraz z nim Ty");
        Console.WriteLine("Odczuwasz wyrzuty sumienia");
        Console.WriteLine("Postanawiasz sprawdzić co u śpiącej królewny z głównego placu");
        Console.WriteLine("Cholera, dalej śpi");
        Console.WriteLine("Szturchanie nic nie daje");
        Console.WriteLine("Ale oddycha, a jak tak to może poczuje zapach");
        Console.WriteLine("Kładziesz swoją dzienną dawkę pod jego nosem");
        Console.WriteLine("Oczy wyskakują mu z twarzy, momentalnie odpala 3 skręty i spala jednym wciągnięciem");
        Console.WriteLine("Twierdzi, że dzięki mnie miał wizje a takich przyjaciół to on zbiera");
        Console.WriteLine("Otrzymujesz i jego poparcie");
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("Udało Ci się zdobyć szacunek w każdej dzielnicy bariery");
        Console.WriteLine("Możesz obecnie wybierać w dostępnych ofertach pracy na tym rynku");
        Console.WriteLine("Może jeszcze więcej expa? Czy przechodzimy do wyboru Gildii?");
        Console.WriteLine("Jeśli chcesz wybrać 1 opcje napisz exp, jeśli wybierasz 2 opcje napisz gildia");
        Console.Write("> ");
        string trzeciWybor = Console.ReadLine();
        if (trzeciWybor == "exp")
        {
            Encounters.LosowaWalka();
            Console.WriteLine("Dzięki walce stajesz się silniejszy");
            currentPlayer.damage += 5;
            Console.WriteLine("Twoje obrażenia zostają zwiększone o 5 pt i obecnie wynoszą " + currentPlayer.damage + "pt ");
            Console.WriteLine("Znajdujesz również amulet ochrony");
            currentPlayer.armorValiu += 4;
            Console.WriteLine("Twój poziom pancerza wynosi " + currentPlayer.armorValiu);

        }
        else if (trzeciWybor == "gildia")
        {
            Console.WriteLine("Musisz to przemyśleć na spokojnie");
            Console.WriteLine("Idziesz się z tym przespać");
        }
        else
        {
            Console.WriteLine("ŹLE PISZESZ");

        }
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("Tak na prawdę to nie ma znaczenia kim chcesz być, jaką gildię wybierasz");
        Console.WriteLine("I tak skończysz na bagnach");
        Console.WriteLine("Z bagien odeślą Cię do kopalni po wydzielinę z pełzaczy");
        Console.WriteLine("Dostaniesz pancerz jako taki");
        currentPlayer.armorValiu += 3;
        Console.WriteLine("Twój poziom pancerza wynosi " + currentPlayer.armorValiu);
        Console.WriteLine("Jako przynależny do obozu, możesz wejść na zamek");
        Console.WriteLine("List który dostałeś na początku okazuje się do arcywroga obecnego arcymaga ognia");
        Console.WriteLine("Dostajesz nic przydatnego w grze, ale ja Ci coś dam");
        currentPlayer.potion += 3;
        currentPlayer.weaponValiu += 5;
        Console.WriteLine("Trochę potek i siłki");
        Console.WriteLine("Mimo wszytko opłacało się iść na zamek, poznałeś Miltena, ciecia wśród magów");
        Console.WriteLine("Musi stać po 24h i pilnować wejścia");
        Console.WriteLine("Wycieczka do kopalni");
        Console.WriteLine("Będąc w kopalni musisz pomóc kilku osobom głównie musisz walczyć");
        Console.WriteLine("Więc szybka losowa walka");
        Console.ReadKey();
        Encounters.LosowaWalka();
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("Mało ciekawe rzeczy się dzieją");
        Console.WriteLine("Aż w KOŃCU masz przejście do Królowej pełzaczy");
        Console.WriteLine("WALKA!!!");
        Console.ReadKey();
        Encounters.KrolowaPelzaczy();
        Console.WriteLine("Wracasz do obozu na bagnie");
        Console.WriteLine("Poznajesz ich wodza");
        Console.WriteLine("Główny mag przesiaduje w swojej jaskini");
        Console.WriteLine("Chce być znalazł zgubioną niebieską baterię z kamienia");
        Console.WriteLine("Czyli kamień ogniskujący");
        Console.WriteLine("Ukradł go jeden z nowicjuszy");
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("Spotykasz go na szczycie góry, w samo południe");
        Console.WriteLine("Jest brzydki");
        Console.WriteLine("Trzymasz rękojeść swojej broni");
        Console.WriteLine("Wysłuchujesz jaki to on potężny z kamieniem");
        Console.ReadKey();
        Encounters.OpentanyNowicjusz();
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("Wracasz z kamieniem");
        Console.WriteLine("Idziesz do głównego maga");
        Console.WriteLine("Ten mówi Ci że potrzebuje instrukcja obsługi do kamienia");
        Console.WriteLine("Był ktoś kto miał się tym zająć, ale chyba nie żyje");
        Console.WriteLine("Kolejna wycieczka");
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("Idziesz drogą jaką miał przejść nieszczęśnik z książką");
        Console.WriteLine("Możesz sprawdzić okoliczny las czy nic tam go nie zjadło");
        Console.WriteLine("Napisz las by go przeszukać, lub droga by iść dalej");
        Console.Write("> ");
        string czwartyWybor = Console.ReadLine();
        if (czwartyWybor == "las")
        {
            Console.WriteLine("Sprawdzając las natrafiasz na przeciwnika");
            Encounters.LosowaWalka();
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Czy chcesz iść dalej w las ?");
            Console.WriteLine("Napisz tak lub nie");
            Console.Write("> ");
            string lasWybor = Console.ReadLine();
            if (lasWybor == "tak")
            {
                Console.WriteLine("Sprawdzając las natrafiasz na przeciwnika");
                Encounters.LosowaWalka();
                Console.WriteLine();
                Console.WriteLine("Po walce znajdujesz kilka uzdrawiających roślin");
                currentPlayer.health += 20;
                Console.WriteLine("Twój poziom życia wynosi " + currentPlayer.health);

            }
            else if (lasWybor == "nie")
            {
                Console.WriteLine("Wracasz na ścieżkę");
            }
            else
            {
                Console.WriteLine("ŹLE PISZESZ");

            }
            Console.ReadKey();
            Console.Clear();


        }
        else if (czwartyWybor == "droga")
        {
            Console.WriteLine("Idziesz dalej drogą");
        }
        else
        {
            Console.WriteLine("ŹLE PISZESZ");

        }
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("Dalej znajdujesz jaskinie z czarnymi goblinami");
        Console.WriteLine("Atakują zawsze grupą");
        Console.ReadKey();
        Encounters.CzarneGobliny();
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("Pokonujesz ich gang");
        Console.WriteLine("Z jednego z nich zdejmujesz pierścień");
        currentPlayer.armorValiu += 8;
        Console.WriteLine("Twoja obrona rośnie i wynosi " + currentPlayer.armorValiu);
        Console.WriteLine("czy chcesz przeszukać jaskinię i skrzynie w niej");
        Console.WriteLine("Napisz tak lub nie");
        Console.Write("> ");
        string jaskiniaWybor = Console.ReadLine();
        if (jaskiniaWybor == "tak")
        {
            Console.WriteLine("Sprawdzając jaskinie natrafiasz na przeciwnika");
            Encounters.LosowaWalka();
            Console.WriteLine("sprawdzasz również skrzynie");
            Console.WriteLine("Po walce znajdujesz kilka uzdrawiających eliksirów");
            currentPlayer.potion += 5;
            Console.WriteLine("Masz obecnie " + currentPlayer.potion + " potek");

        }
        else if (jaskiniaWybor == "nie")
        {
            Console.WriteLine("Wracasz na ścieżkę");
        }
        else
        {
            Console.WriteLine("ŹLE PISZESZ");

        }
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("Przy przejściu znajdujesz nieszczęśnika");
        Console.WriteLine("Instrukcja jest cała");
        Console.WriteLine("Wracasz do głównego maga");
        Console.WriteLine("Jest już gotowy");
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("Dziś wieczorem będzie impreza");
        Console.WriteLine("Uczniowie się zbierają na głównym placu");
        Console.WriteLine("Główny mag jest doskonale widoczny z wzniesienia");
        Console.WriteLine("Zaczął wzywać swoje bóstwo, dostał tylko wizję");
        Console.WriteLine("Opowiedział co widział i umarł");
        Console.WriteLine("Miał wizje o cmentarzu orków");
        Console.WriteLine("Więc tam Cię teraz wysyłają by sprawdzić co tam jest");
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("Idziesz na orki, orki z majorki");
        Encounters.Ork();
        Console.ReadKey();
        Console.WriteLine("Cmentarz to jaskinia w której jest dużo orków");
        Console.WriteLine("Martwych i żywych");
        Console.WriteLine("Szybko zmieniasz równowagę na przewagę tych martwych");
        Console.WriteLine("Zbierasz broń po orkach");
        currentPlayer.weaponValiu += 10;
        Console.WriteLine("Twoje obrażenia od broni wynoszą " + currentPlayer.weaponValiu);
        Console.WriteLine("Przychodzi jeden magów z bagien");
        Console.WriteLine("Zwiedzacie razem jaskinie");
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("Musicie pokonać kolejnego orka");
        Encounters.Ork();
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("Wraz z nowym znajomym spędzacie miło czas");
        Console.WriteLine("On co raz modli się do śniącego");
        Console.WriteLine("Czasem poleci mu piana z buzi");
        Console.WriteLine("Nawet go polubiłeś");
        Console.WriteLine("Ale niestety śniący go opętał i musicie walczyć");
        Encounters.OpentanyMag();
        Console.ReadKey();
        Console.WriteLine("Wracasz na bagna ");
        Console.WriteLine("Mówisz im, że śniący to demon");
        Console.WriteLine("Że to on miesza im w głowie");
        Console.WriteLine("Plan tego obozu na ucieczkę spod bariery został zniszczony");
        Console.WriteLine("Czas na nowy plan");
        Console.WriteLine("W nowym obozie mają taki duży kopiec rudy");
        Console.WriteLine("I to magicznej");
        Console.WriteLine("Mają plan by go wysadzić");
        Console.WriteLine("Łącznie z barierą");
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("Lubisz wybuch więc się zgadzasz");
        Console.WriteLine("Za Twoje zasługi Twój obóz...");
        Console.WriteLine("...który wybrałeś wcześniej w głowie");
        Console.WriteLine("Postanawia dać Ci awans");
        Console.WriteLine("Twoje statystyki lecą w górę");
        currentPlayer.health += 20;
        currentPlayer.armorValiu += 10;
        currentPlayer.damage += 10;
        Console.WriteLine("Życie " + currentPlayer.health + ", Obrona " + currentPlayer.armorValiu + ", Obrażenia " + currentPlayer.damage);
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("W nowym obozie idziesz do głównego maga");
        Console.WriteLine("Każe znaleźć Ci pozostałe ogniskujące kamienie");
        Console.WriteLine("Kamieni jest łącznie 5, jeden już masz");
        Console.WriteLine("Dostajesz mapę bariery z pentagramem");
        Console.WriteLine("Więc ruszasz na jej rogi");
        Encounters.LosowaWalka();
        Console.ReadKey();
        Console.WriteLine("Jesteś w górach, blisko miejsca gdzie Cię zrzucili");
        Console.WriteLine("Widzisz Diego, który ostrzega Cię przed Trollem");
        Console.WriteLine("Idziecie razem na stwora");
        currentPlayer.damage *= 2;
        Console.WriteLine("Obecnie wasz power lvl to " + currentPlayer.damage);
        Encounters.DuzyTroll();
        Console.ReadKey();
        Console.WriteLine("Żegnasz się ze swoim przyjacielem, zabierasz kamień i lecisz dalej");
        Console.WriteLine("Kolejne jest zamczysko a w nim Gorn z toporem");
        Console.WriteLine("Tu też jest troll, ale mały");
        Console.WriteLine("Razem idziecie go bić");
        Encounters.MalyTroll();
        Console.ReadKey();
        Console.WriteLine("Bierzesz kolejny kamień i biegniesz dalej");
        Console.WriteLine("Znajdujesz grobowiec a przed nim ognisty kolega Milten");
        Console.WriteLine("Wchodzicie do grobowca by zabić tych co nie powinni już żyć");
        Encounters.Trup();
        Console.ReadKey();
        Console.WriteLine("Kolejny kamyczek do kolekcji i w drogę");
        Console.WriteLine("Ostatnia jest forteca");
        Console.WriteLine("W niej czeka Lester");
        Console.WriteLine("Czas na przemoc");
        Encounters.HarpiaDuza();
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("Masz już wszystko, wracasz do głównego maga wody");
        Console.WriteLine("Ma już kolekcję kamieni");
        Console.WriteLine("Przypomniał sobie że był kiedyś jeszcze jeden mag pod barierą");
        Console.WriteLine("Ten który odszedł od Gomeza");
        Console.WriteLine("Schował się gdzieś na terytorium orków");
        Console.WriteLine("Masz go poszukać ");
        Console.WriteLine("Za swoje czyny oraz na drogę dostajesz 3 potki");
        currentPlayer.potion += 3;
        Console.WriteLine("Możesz kupić na targu lepszą zbroje i miecz");
        Console.WriteLine("Za zestaw sprzedawca chce 610 bryłek");
        Console.WriteLine("Czy chcesz dokonać zakupu? napisz tak lub nie");
        Console.Write("> ");
        string sklepWybor = Console.ReadLine();
        if (sklepWybor == "tak")
        {
            if (currentPlayer.coins >= 610)
            {
                currentPlayer.coins -= 610;
                Console.WriteLine("Super okazja, czyszczenie magazynów");
                Console.WriteLine("Kupiłeś co chciałeś");
                currentPlayer.weaponValiu += 15;
                currentPlayer.armorValiu += 15;
                Console.WriteLine("Obrażenia od broni: " + currentPlayer.weaponValiu + " |  Redukcja obrażeń " + currentPlayer.armorValiu);
            }
            else
            {
                Console.WriteLine("Bieda, nie stać Cię");
            }

        }
        else if (sklepWybor == "nie")
        {
            Console.WriteLine("Ogarnia Cię smutek, taka okazja na pewno jest tylko raz");
        }
        else
        {
            Console.WriteLine("ŹLE PISZESZ");

        }
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("Na terytorium orków zaczepiasz orków");
        Console.WriteLine("Fleszbeki z cmentarza");
        Encounters.Ork();
        Console.ReadKey();
        Console.WriteLine("Po spacerku zauważasz wysoką wieże");
        Console.WriteLine("Czyli dziadek się musi dobrze trzymać");
        Console.WriteLine("Okazuje się że ma własną brygadę budowlaną");
        Console.WriteLine("Stworzył kilka szkieletów i demonów");
        Console.WriteLine("Mimo że jest ślepy, ma ładne widoki z góry");
        Console.WriteLine("Dzielnica może nie ciekawa bo obok wioski orków");
        Console.WriteLine("Więc to nie pachnie za ładnie ani nie jest cicho");
        Console.WriteLine("Ale ludzi nie ma, fotowoltaika nie jest nim zainteresowana");
        Console.WriteLine("Dziadzio Xardi bo tak go nazywasz wysłał Cię do swojej wcześniejszej chałupki");
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("Która niespodziewania znajduje się pod wodą");
        Console.WriteLine("Szybka kąpiel, czas na świeżość");
        Console.WriteLine("W środku nie było innych świeżych ludzi");
        Console.WriteLine("Chyba wcześniej dziadek zatrudniał zwykłych ludzi... ");
        Console.WriteLine("Bo teraz przez jego czary mary są same zombie");
        Console.WriteLine("Czas by zaznali spokoju");
        Encounters.SilnyZombie();
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("Przeszukujesz stare graty Xardusia");
        Console.WriteLine("Znalazłeś turbo pancerz magicznie bojowy");
        currentPlayer.armorValiu += 35;
        Console.WriteLine("Obecna obrona wynosi " + currentPlayer.armorValiu);
        Console.WriteLine("Wychodząc widzisz blisko orka, ale jakiś taki inny");
        Console.WriteLine("Ma pomalowaną twarz, dużą belkę, kamyki i piórka");
        Console.WriteLine("Postanawiasz po raz pierwszy, że nie zabijesz go od razu");
        Console.WriteLine("Umie mówić po naszemu");
        Console.WriteLine("Gadacie troszkę, miło spędzacie czas, ze śmieci które zbierasz od początku zrobił Ci broń");
        Console.WriteLine("Twierdzi, że dzięki niej żaden ork nas nie zaatakuje");
        currentPlayer.weaponValiu += 9;
        Console.WriteLine("Wartość obrażeń od broni rośnie do " + currentPlayer.weaponValiu);
        Console.WriteLine("Czas wracać do dziadka");
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("Dziadek chce byś już jak możesz to poszedł odwiedzić orków");
        Console.WriteLine("Obejrzeć co tam tak głośno po nocy w jaskini");
        Console.WriteLine("Idziesz bo chcesz dobry chłopak być");
        Console.WriteLine("Ale orkowie mają tam labirynt");
        Console.WriteLine("Znajdujesz legendarną broń przy okazji");
        Console.WriteLine("Która może służyć co najwyżej za drapaczkę do pleców bo się rozładowała");
        Console.WriteLine("Wracasz z płaczem do dziadka");
        Console.WriteLine("Dziadek pomóż");
        Console.WriteLine("-Pamiętasz chłopczyku ten kopiec magicznej rudy");
        Console.WriteLine("Już wiesz co masz robić");
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("Kopiec jest strzeżony, ale Tobie pozwolili popatrzeć z bliska");
        Console.WriteLine("Przyszedł też Milten");
        Console.WriteLine("Ty wsadzasz miecz a on robi czary");
        Console.WriteLine("Kopiec magicznej rudy zmienia się w kopiec rudy");
        Console.WriteLine("Magowie wody są czerwoni aż woda paruje");
        Console.WriteLine("Magowie czajników");
        Console.WriteLine("Teleportacja do dziadka, a Ty Milten sobie radź");
        Console.WriteLine("Masz teraz miecz XPROXurizjelXPROX");
        currentPlayer.weaponValiu += 50;
        Console.WriteLine("Dziadek zadowolony, dumny");
        Console.WriteLine("A teraz czas zabić głównego bosa");
        Console.WriteLine("To wszystko wina śpiącego, to on zrobił że bariera jest taka duża");
        Console.WriteLine("Jak go zabijesz, zniszczysz barierę");
        Console.WriteLine("Dostajesz jeszcze potki i w drogę");
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("W świątyni orków która jest pod ich wioską jest kilku opętanych wyznawców");
        Console.WriteLine("Masz ich na hita");
        Console.WriteLine("Teraz główny boss");
        Encounters.Sniacy();
        Console.ReadKey();
        Console.WriteLine("Zabijasz bestie i zaczyna ją wsysać gdzieś do czarnej dziury");
        Console.WriteLine("Jaskinia wali się");
        Console.WriteLine("Wszystko spada na Ciebie");
        Console.WriteLine("Bariera upada, ty też");
        Console.WriteLine("KONIEC GRY reszta w II");
    }
}