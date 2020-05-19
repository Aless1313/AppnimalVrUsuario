using Microsoft.Win32.SafeHandles;
using Plugin.TextToSpeech;
using Plugin.TextToSpeech.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Appnimalv2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class animalescaneado : ContentPage
    {
        static CrossLocale? locale = null;
        public animalescaneado(string animal)
        {
            InitializeComponent();


            switch (animal)
            {

                case "llamas":
                    llamas();
                    break;

                case "antilopeaddax":
                    antilopeaddax();
                    break;

                case "nu":
                    nu();
                    break;


                case "ciervo":
                    ciervo();
                    break;


                case "nilgai":
                    nilgai();
                    break;

                case "camellos":
                    camellos();
                    break;

                case "longhorn":
                    longhorn();
                    break;

                case "flandes":
                    flandes();
                    break;

                case "Antilopeacuatico":
                    antilopeacuatico();
                    break;

                case "jirafa":
                    jirafa();
                    break;

                case "oryx":
                    oryx();
                    break;

                case "cebra":
                    cebra();
                    break;

                case "elefante":
                    elefante();
                    break;

                case "aviario":
                    aviario();
                    break;

                case "oryxcabo":
                    oryxdelcabo();
                    break;

                case "cabra":
                    cabra();
                    break;

                case "avestruz":
                    avestruz();
                    break;

                case "muntiaco":
                    muntiaco();
                    break;

                case "canguro":
                    canguro();
                    break;

                case "rinoceronte":
                    rinoceronte();
                    break;

                default:
                    DisplayAlert("Error", "No se encontró animal", "Volver");
                    break;
            }
        }


        public async void llamas()
        {
           
            await CrossTextToSpeech.Current.Speak(lbl_Info.Text, pitch: 1.0f, speakRate: 5, volume: 75f);

            lbl_animal.Text = "Llamas";
            lbl_Info.Text= "La llama es el pariente sudamericano del camello, aunque no tiene joroba. " +
                "Es un animal muy fuerte que fue domesticado por los habitantes de los Andes. " +
                "Sus parientes salvajes son los guanacos y las vicuñas. " +
                "Las llamas pastan en la hierba y, al igual que las vacas, regurgitan la comida y la rumian. " +
                "Mastican la hierba durante un tiempo antes de tragarla para hacer la digestión completa. ";
            lbl_curiosidad.Text = " ¿Sabias qué? Los indígenas las usaron durante siglos como animales de carga," +
                " pudiendo soportar entre 23 y 34 kilogramos y recorrer con ese peso hasta 32 kilómetros en un solo día. " +
                "Un séquito de llamas, que puede estar formado por varios cientos de individuos, " +
                "puede transportar un gran volumen de carga a lo largo de las duras cordilleras andinas.";
            imagenanimal.Source = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b9/Llama_lying_down.jpg/250px-Llama_lying_down.jpg";
        }

        public void antilopeaddax()
        {
            lbl_animal.Text = "Antílope Addax";
            lbl_Info.Text = "El addax (Addax nasomaculatus) es una especie de mamífero artiodáctilo de la familia Bovidae" +
                " Al igual que el resto de los miembros de su subfamilia (Hippotraginae), es un antílope de 1 m de altura" +
                " y unos 120 kg de peso, formas redondeadas, patas largas y perfil recto; no obstante no presenta " +
                "los mismos caracteres equinoides del resto de la familia siendo más parecido a un antílope convencional.";
            lbl_Info.Text= "¿Sabias qué? A pesar de que no tienen un gran sentido de la vista " +
                "estos animales suelen salir en busca de comida cuando cae la noche para protegerse del calor diurno.";
            imagenanimal.Source = "https://www.elmundo.cr/wp-content/uploads/2017/10/antilope-Adax-conservaci%C3%B3n-Alemania.jpg";
        }

        public void nu()
        {
            lbl_animal.Text = "Ñu";
            lbl_Info.Text = "Los ñus tienen un aspecto desgarbado que recuerda a un extraño cruce entre vaquilla y antílope," +
                " con crines largas y desgreñadas y cola empenachada de caballo. Poseen largas barbas que cuelgan a lo largo " +
                "de todo el cuello desde la barbilla hasta el pecho, y patas muy largas de pezuñas afiladas. " +
                "Se cuentan entre los herbívoros que mejor prosperan en África y forman los rebaños más numerosos de la Tierra.";
            lbl_curiosidad.Text = "¿Sabias qué? Las hembras alumbran al principio de la estación de las lluvias y las crías pueden correr " +
                "a los pocos minutos de nacer; durante su juventud, los ñus son incluso más rápidos en la carrera que sus " +
                "adultos, pudiendo alcanzar los 80 km/h y los más viejos alcanzan los 60 km/h.";
            imagenanimal.Source = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fb/Blue_Wildebeest%2C_Ngorongoro.jpg/250px-Blue_Wildebeest%2C_Ngorongoro.jpg";
        }

        public void ciervo()
        {
            lbl_animal.Text = "Ciervo";
            lbl_Info.Text = "El venado cola blanca, ciervo cola blanca, ciervo de Virginia, venado de Virginia o venado gris " +
                "(Odocoileus virginianus) es una especie de mamífero artiodáctilo de la familia de los cérvidos. " +
                "Vive en diferentes ecosistemas de América, desde los canadienses, en la región subártica, pasando por los " +
                "bosques secos de las laderas montañosas de México, las selvas húmedas tropicales de América Central y del Sur," +
                " hasta los bosques secos ecuatoriales del norte del Perú y otras áreas boscosas sudamericanas." +
                "​ Se alimenta de arbustos y hierbas.";
            lbl_curiosidad.Text = " ¿Sabias qué? De esta especie en particular se baso aquel personaje de la pelicula de Bambi";
            imagenanimal.Source = "https://www.dondevive.org/wp-content/uploads/2016/06/donde-vive-el-ciervo-768x512.jpg";
        }

        public void nilgai()
        {
            lbl_animal.Text = "Nilgai";
            lbl_Info.Text = " El nilgai es el antílope más grande de Asia. Se encuentra a 1–1.5 metros (3.3–4.9 pies) en el hombro;" +
                "  la longitud de la cabeza y el cuerpo es típicamente entre 1.7–2.1 metros (5.6–6.9 pies). " +
                " Los machos pesan 109–288 kilogramos (240–635 lb); El peso máximo registrado es de 308 kilogramos (679 lb)." +
                " Las hembras son más livianas, pesan 100–213 kilogramos (220–470 lb).  El dimorfismo sexual es prominente; " +
                "los machos son más grandes que las hembras y difieren en coloración.";
            lbl_curiosidad.Text = "¿Sabias qué? Se han descubierto restos de nilgai que datan del Pleistoceno en las cuevas" +
                " de Kurnool en el sur de India. La evidencia sugiere que fueron cazados por humanos durante el período " +
                "Mesolítico(hace 5,000 a 8,000 años).";
            imagenanimal.Source = "https://texasfarmbureau.org/wp-content/uploads/2016/07/071116nilgai.jpg";
        }

        public void camellos()
        {
            lbl_animal.Text = "Dromedarios (Camellos)";
            lbl_Info.Text = "El dromedario o camello arábigo (Camelus dromedarius) es una especie de mamífero" +
                " artiodáctilo de la familia Camelidae.​ Es similar al camello bactriano (Camelus bactrianus), " +
                "del que se diferencia por su pelaje generalmente más corto, cuerpo menos robusto y presencia " +
                "de una joroba en lugar de dos.";
            lbl_curiosidad.Text = "¿Sabias qué? Su capacidad de resistencia ante la deshidratación los ha hecho unos animales muy valiosos en el desierto. " +
                "El dromedario puede llegar a beber hasta 150 litros de agua en muy poco tiempo. ";
            imagenanimal.Source = "https://upload.wikimedia.org/wikipedia/commons/thumb/6/6b/Fuerte_Al_Koot%2C_Doha%2C_Catar%2C_2013-08-06%2C_DD_02.JPG/220px-Fuerte_Al_Koot%2C_Doha%2C_Catar%2C_2013-08-06%2C_DD_02.JPG";
        }

        public void longhorn()
        {
            lbl_animal.Text = "Longhorn";
            lbl_Info.Text = "Texas longhorn es una raza de ganado que se distingue sobre todo por sus cuernos, " +
                "que pueden llegar a medir hasta dos metros, así como por sus cuartos traseros levemente alzados y " +
                "sus manchas blancas diseminadas sobre la piel que, según los individuos, puede variar mucho en color";
            lbl_curiosidad.Text = "¿Sabias qué? Algunos rancheros de Texas manifestaron su interés en mantener la raza" +
                " por su interés histórico y comenzaron a criarla en su estado, de allí su nombre Texas longhorn, " +
                "aunque a estas vacas se las llamaba originalmente solamente longhorn, igual que la raza homónima " +
                "de las islas británicas.";
            imagenanimal.Source = "https://resize.hswstatic.com/w_907/gif/Texas-longhorn.jpg";
        }

        public void flandes()
        {
            lbl_animal.Text = "Gigante Flandes";
            lbl_Info.Text = "El conejo gigante de Flandes (Oryctolagus cuniculus) como su nombre lo indica es un animal " +
                "de gran tamaño y volumen; característica que ubica a esta raza entre las más grandes de la especie. " +
                "A diferencia de otras razas, el conejo gigante de Flandes sobrepasa el tamaño y peso medios de los conejos" +
                " al alcanzar 18 kilos de peso en los individuos más grandes.";
            lbl_curiosidad.Text = "¿Sabias qué? Otra de las particularidades de la especie radica en los 10 posibles " +
                "tonos que pueden presentar en su pelaje, siendo el negro, beige, azul, amarronado, blanco, gris claro y " +
                "acero los más comunes.Otra de las particularidades de la especie radica en los 10 posibles tonos que " +
                "pueden presentar en su pelaje, siendo el negro, beige, azul, amarronado, blanco, gris claro y acero " +
                "los más comunes.";
            imagenanimal.Source = "https://www.mundoconejos.com/wp-content/uploads/2018/11/Conejo-gigante-de-Flandes.jpg";
        }

        public void antilopeacuatico()
        {
            lbl_animal.Text = "Antílope Acuático";
            lbl_Info.Text = "El antílope acuático es uno de los antílopes de mayor peso, " +
                "diferenciándose con facilidad gracias a los cuernos anillados que presentan " +
                "los machos y que pueden alcanzar el metro de longitud. Se conocen dos subespecies" +
                " de antílope acuático que son bastante diferentes genéticamente, aunque hay mucha " +
                "hibridación entre ellas en estado salvaje.";
            lbl_curiosidad.Text = "¿Sabias qué? Esta especie de antílope tiene las pezuñas más largas y " +
                 "abiertas que la mayoría de los antílopes para desplazarse por los fondos " +
                 "lodosos de los ríos y charcas. No dudarán en correr hacia el agua si se " +
                 "sienten amenazados ya que son buenos nadadores.";
            imagenanimal.Source = "https://gdlahora.com/wp-content/uploads/2016/01/antilope-acuatico.jpg";
        }

        public void jirafa()
        {
            lbl_animal.Text = "Jirafa";
            lbl_Info.Text = "La jirafa es el animal terrestre más alto del mundo y uno de los protagonistas indiscutibles " +
                "de la sabana africana. Esta peculiar especie puede llegar a medir 5 metros de altura. " +
                "Para hacerse una idea, solamente sus patas llegan a medir dos metros, bastante más que la altura media de" +
                " los seres humanos. En cuanto a su peso, los machos alcanzan los 1.600 kilos, mientras que las hembras " +
                "rondan los 800. Además de su altura, otro de los aspectos más llamativos de las jirafas son sus" +
                " manchas oscuras, negras o marrones y dentadas o redondeadas, que contrastan con su pelaje amarillento.";
            lbl_curiosidad.Text = "¿Sabias qué? Por su apariencia peculiar, la jirafa fue una fuente de fascinación" +
                " en diversas culturas, tanto antiguas como modernas, y apareció con frecuencia en pinturas, libros y " +
                "dibujos animados.";
            imagenanimal.Source = "https://cumbrepuebloscop20.org/wp-content/uploads/2018/09/jirafa.jpg";
        }

        public void oryx()
        {
            lbl_animal.Text = "Oryx del Sahara";
            lbl_Info.Text = "El órix de cuernos de cimitarra u órix blanco (Oryx dammah) es una especie de antílope " +
                "africano de la subfamilia Hippotraginae. Es la única especie de Oryx que posee cuernos curvos, " +
                "lo que le da el nombre común. Su aspecto es usual en el género, pero sus cuernos se curvan hacia" +
                " atrás en forma de cimitarra y su pelaje, aunque blanco, es de color rojizo en las patas y el cuello," +
                " mientras que la máscara facial es casi ausente.";
            lbl_curiosidad.Text = "¿Sabias qué? Esta especie presenta la particularidad de que fue domesticada en el Antiguo " +
                "Egipto como animal productor de carne. Eventualmente su domesticación cayó en desuso debido a la agresividad" +
                " de la especie. Se distribuía por todo el territorio sahariano.";
            imagenanimal.Source = "https://bybio.files.wordpress.com/2014/01/addax-or-screwhorn-antelope.jpg?w=584&h=389";
        }

        public void cebra()
        {
            lbl_animal.Text = "Cebra";
            lbl_Info.Text = "La cebra de llanura, de sabana, de planicie o simplemente común (Equus quagga), " +
                "es el tipo más común y extendido de cebra. Es propia de las llanuras y sabanas desde el sur" +
                " de Etiopía a lo largo del África oriental, y tan al sur como Angola y la parte oriental de Sudáfrica." +
                " Las cebras de la llanura son muy sociables y comúnmente viven en pequeños grupos compuestos por un" +
                " solo macho y una, dos o varias hembras con sus crías. Estos grupos son permanentes, " +
                "y tienden a variar según el hábitat: en campos pobres, los grupos suelen ser pequeños.";
            lbl_curiosidad.Text = "¿Sabias qué? De vez en cuando, familias de cebras de la llanura" +
                " se agrupan en grandes manadas de cebras y otras especies, especialmente el ñu y otros antílopes.";
            imagenanimal.Source = "https://okdiario.com/img/2019/07/01/cebra-domesticada-655x368.jpg";
        }

        public void elefante()
        {
            lbl_animal.Text = "Elefante";
            lbl_Info.Text = "Los elefantes o elefántidos (Elephantidae) son una familia de mamíferos placentarios del " +
                "orden Proboscidea. Antiguamente se clasificaban, junto con otros mamíferos de piel gruesa, en el orden," +
                " ahora inválido, de los paquidermos (Pachydermata). Existen hoy en día tres especies y diversas subespecies." +
                " Entre los géneros extintos de esta familia destacan los mamuts. Los elefantes son los animales terrestres" +
                " más grandes que existen en la actualidad.​ El periodo de gestación es de veintidós meses, el más largo en" +
                " cualquier animal terrestre.";
            lbl_curiosidad.Text = "¿Sabias qué? El peso al nacer usualmente es 118 kg." +
                "Normalmente viven de cincuenta a setenta años, pero registros antiguos documentan edades " +
                "máximas de ochenta y dos años.";
            imagenanimal.Source = "https://img2.rtve.es/i/?w=1600&i=1559067811588.jpg";
        }

        public void aviario()
        {
            lbl_animal.Text = "Aviario";
            lbl_Info.Text = "Un aviario es una gran jaula para encerrar aves. Al contrario de las jaulas de pájaros, " +
                "los aviarios permiten a las aves un mayor espacio para volar. Estos a menudo contienen plantas y " +
                "arbustos que logran la simulación de un hábitat natural. Los aviarios son populares entre aquéllos" +
                " a los que le gusta criar aves domésticas procurando que tengan espacio.";
            lbl_curiosidad.Text = "¿Sabias qué? El aviario casero suele ser un producto de tipo hágalo usted mismo," +
                " aunque los hay también disponibles comercialmente para encajar en interiores y exteriores.";
            imagenanimal.Source = "https://cdn.local.mx/wp-content/uploads/2018/07/grid21.jpg";
        }

        public void oryxdelcabo()
        {
            lbl_animal.Text = "Oryx del cabo";
            lbl_Info.Text = "El órice del Cabo (Oryx gazella), también conocido como órix del Cabo, gacela órice," +
                " pasán o gemsbok, es una especie de antílope africano de la subfamilia Hippotraginae. " +
                "Vive en manadas de hasta 40 individuos, pero en la estación lluviosa se reúnen cientos. " +
                "En época de sequía puede pasar muchos días sin beber, sobreviviendo de la humedad de los frutos y raíces. " +
                "Mide hasta 1,6 metros de largo y la altura hasta la cruz llega a 1,2 metros.";
            lbl_curiosidad.Text = "La única diferencia exterior entre machos y hembras son sus cuernos. " +
                "Muchos cazadores de hembras matan machos por error. Es una de las pocas especies de " +
                "antílope en que los trofeos de las hembras son a veces más deseables que los masculinos.";
            imagenanimal.Source = "https://upload.wikimedia.org/wikipedia/commons/thumb/5/55/Oryx_gazella_%28Okevi%29.jpg/250px-Oryx_gazella_%28Okevi%29.jpg";
        }

        public void cabra()
        {
            lbl_animal.Text = "Cabra";
            lbl_Info.Text = "La cabra (Capra aegagrus hircus) es un mamífero artiodáctilo de la subfamilia Caprinae que" +
                " fue domesticado alrededor del octavo milenio a. C., sobre todo por su carne y leche.1​ Al macho de la" +
                " cabra se le llama cabrón (si bien en algunos países esta palabra se considera malsonante), así como " +
                "también cabro, chivato, macho cabrío, irasco o chivo, y a las crías se las llama cabrito, chivo o chivito." +
                " Al conjunto de estos animales, criados por el hombre, se le conoce como ganado caprino o ganado cabrío";
            lbl_curiosidad.Text = "¿Sabias qué? La cabra fue un animal muy venerado en Mendes en Egipto. " +
                "Estaba prohibido matarla, porque creían que Pan, gran divinidad de esta ciudad, se había " +
                "ocultado bajo la figura de una cabra por esto se le representaba con rostro de este animal.";
            imagenanimal.Source = "https://www.oviespana.com/media/k2/items/cache/57d2bbcb7f2d19d86cd747ffbed473f3_L.jpg";
        }

        public void avestruz()
        {
            lbl_animal.Text = "Avestruz";
            lbl_Info.Text = "Es el ave más grande y de mayor peso del mundo. Cuando nacen los polluelos miden entre " +
                "25 y 30 cm de altura, pesando unos 900 g. Durante el primer año de vida los polluelos crecen unos " +
                "25 cm al mes. Los machos adultos pueden llegar a alcanzar los 2,75 o incluso 3 metros, y pesar " +
                "alrededor de 180 kg.";
            lbl_curiosidad.Text = "¿Sabias qué? Su longevidad está entre los treinta y cuarenta años, " +
                "aunque en cautividad pueden llegar a cumplir cincuenta años.";
            imagenanimal.Source = "https://sooluciona.com/wp-content/uploads/2018/12/alas-del-avestruz.jpg";
            
        }

        public void muntiaco()
        {
            lbl_animal.Text = "Muntíaco";
            lbl_Info.Text = "Muntiacus o muntíacos es un género de mamíferos rumiantes de la familia Cervidae conocidos" +
                " vulgarmente como muntíacos o muntjacos. Existen una decena de especies originarias todas del Sudeste asiático," +
                " si bien algunas han sido introducidas en Europa.";
            lbl_curiosidad.Text = "¿Sabias qué? Entre los tipos de este animal se encuentran: Muntíaco amarillo de Borneo, " +
                "Muntíaco negro, Muntíaco de Fea, Muntíaco de Gongshan, Muntíaco de la India, Muntíaco de Hukawng, " +
                "Muntíaco de Reeves, Muntiaco de Truong Son";
            imagenanimal.Source = "http://2.bp.blogspot.com/-dyLMRJTdGRY/VEm82OReP7I/AAAAAAAAPUU/Wk0zX4Y3Gvk/s1600/muntiaco-india-hierba.jpg";
            
        }

        public void canguro()
        {
            lbl_animal.Text = "Canguro";
            lbl_Info.Text = "Los canguros poseen grandes y poderosas patas traseras, grandes pies diseñados para saltar," +
                " una cola larga y musculosa para mantener el equilibrio y una cabeza pequeña.La disposición de sus patas " +
                "y cola les permite alcanzar increíbles velocidades. La cabeza fina tiene grandes orejas que se mueven " +
                "independientemente una de otra. Las hembras tienen en el vientre la famosa bolsa marsupial, en la que " +
                "llevan a sus pequeños.";
            lbl_curiosidad.Text = "¿Sabias qué? Los canguritos al nacer miden a penas 3 cm. Solo tienen completamente formadas las manos, " +
                "con las que se agarran al pelaje dentro de la bolsa de su madre.";
            imagenanimal.Source = "https://www.dw.com/image/51418266_401.jpg";
        }

        public void rinoceronte()
        {
            lbl_animal.Text = "Rinoceronte";
            lbl_Info.Text = "Es uno de los tres animales más grandes del mundo, junto con el hipopótamo y el elefante," +
                " pertenece a la orden de los perisodáctilos, es herbívoro y habita en algunas zonas de África y en el" +
                " sur del continente asiático. Viven unos 60 años de media en condiciones favorables. Su nombre en griego" +
                " significa nariz y cuerno, su rasgo más característico.";
            lbl_curiosidad.Text = "¿Sabias qué? A pesar de que no tienen un gran sentido" +
                " de la vista, estos animales suelen salir en busca de comida cuando cae " +
                "la noche para protegerse del calor diurno. ";
            imagenanimal.Source = "https://www.nationalgeographic.com.es/medio/2018/02/27/rino__1280x720.jpg";
       
        }

        private async void btn_idioma_Clicked(object sender, EventArgs e)
        {
            var locales = await CrossTextToSpeech.Current.GetInstalledLanguages();
            var items = locales.Select(a => a.ToString()).ToArray();
            var selected = await DisplayActionSheet("Idioma", "Ok", null, items);

            if(string.IsNullOrWhiteSpace(selected) || selected=="Ok")
            {
                return;
            }

            if(Device.RuntimePlatform == Device.Android)
            {
                locale = locales.FirstOrDefault(l => l.ToString() == selected);
            }
        }
        
        private async void btn_speak_Clicked(object sender, EventArgs e)
        {
            btn_speak.IsEnabled = false;
            var text = lbl_Info.Text;

            

            await CrossTextToSpeech.Current.Speak(text, pitch: 1, speakRate: 1, volume: 2, crossLocale: locale);
            btn_speak.IsEnabled = true;


        }

     

       
    }

}