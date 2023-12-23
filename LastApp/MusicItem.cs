using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastApp
{
    public class MusicItem
    {
        public string Name {  get; set; }
        public string ImageUrl { get; set; }
    }

    public class MusicData
    {
        public List<MusicItem> Guitars { get; set;}
        public List<MusicItem> Bass { get; set;}
        public List<MusicItem> Earphone { get; set; }
        public List<MusicItem> Speaker { get; set; }
        public List<MusicItem> Drum { get; set; }
        public List<MusicItem> Keyboards { get; set; }

        public MusicData()
        {
            Guitars = new List<MusicItem>()
            {
                new MusicItem() {Name="Stratocaster",ImageUrl= "stratocaster.jpg" },
                new MusicItem() {Name="大部分的電吉他都為實心電吉他，琴身是由一塊實心木頭組成，沒有任何空心空間或腔室。這種類型的吉他可以彈奏出非常乾淨、清晰的聲音，具有良好的延音和強大的起音，通常用於搖滾、金屬和其他需要大量破音和增益的音樂風格。\r\n\r\n一些實心吉他的例子包括 Fender Stratocaster、Gibson Les Paul、Ibanez RG 系列和 PRS S2 系列，這些吉他以其清晰、有力的聲音而聞名，經常用於搖滾、金屬和其他需要大量增益和破音的音樂風格。"},
                new MusicItem() { Name = "Telecaster", ImageUrl = "telecaster.jpg" },
                new MusicItem() {Name="Fender Telecaster（有時亦簡稱為「Tele」）是一種電吉他的型號。它由美國吉他製造商芬達樂器公司由1950年開始一直生產至今，也世界上第一款量產並且取得了商業上的成功的實心電吉他。它原本是分成兩條產品線的，一條是Esquire，另一條是Broadcaster。後者的名稱由於法律問題，不得不改名為Telecaster。Telecaster自出現以來被許多知名的音樂家演奏過。當今，人們普遍認為它與Fender Stratocaster和Gibson Les Paul一同屬於電吉他經典型號。"},
                new MusicItem() { Name = "Les paul", ImageUrl = "lespaul.jpg" },
                new MusicItem() {Name="單切角吉他的經典型號範例是 Gibson Les Paul。Les Paul 的身體一側靠近頸部有一個缺口，這種設計類似於雙切角，但它的琴身造型更加流線型。\r\n\r\nLes Paul 具有豐富、飽滿的聲音，常用於搖滾、藍調和其他需要強勁、有力音調的音樂風格。"},
                new MusicItem() { Name = "Explorer", ImageUrl = "explorer.jpg" },
                new MusicItem() {Name="Gibson Explorer 吉他的一個經典範例型號為” Gibson Explorer 2016 T “。Explorer 是一種獨特而獨特的吉他形狀，由 Gibson 在 1950 年代首次推出。\r\n\r\n它有一個尖的、不對稱的身體形狀，有鋒利的邊緣和靠近頸部的鋒利的缺角。"},
                new MusicItem() { Name = "Flying v", ImageUrl = "flyingv.jpg" },
                new MusicItem() {Name="Gibson Flying V 就是V 型吉他的一個經典例子，由 Gibson 在 1950 年代後期首次推出。它呈尖”V”字形，頸部與身體形成一個銳角。\r\n\r\nFlying V 具有前衛的外觀，通常與重金屬和硬搖滾音樂聯繫在一起，許多著名的吉他手都彈過 Flying V，包括 Jimi Hendrix、Kirk Hammett 和 Dave Mustaine。\r\n\r\n"},
                new MusicItem() { Name = "Steve vai", ImageUrl = "stevevai.jpg" },
                new MusicItem() {Name="super strat 吉他最經典的範例為 Ibanez RG 系列。super strat 造型為經典 Fender Stratocaster 設計的變形版，具有稍大且更圓潤的琴身以及更寬、更平的琴頸。\r\n\r\nsuper strat 專為高速演奏和輕鬆觸及指板高把位而設計，常用於搖滾、金屬和其他快節奏音樂風格。"},
            };
            Bass = new List<MusicItem>()
            {
                new MusicItem() {Name="J bass",ImageUrl= "jbass.jpg" },
                new MusicItem() {Name="常見的 JAZZ BASS 被傳奇樂器公司 Fender 發明於 1960 年。 通常 JAZZ BASS 由有兩塊單線圈拾音器組合而成，音色明亮富有動態，更適用於爵士樂，FUNK MUSIC 等音樂類型裡，具有彈性的音色也更受許多 Slap 技巧愛好者的青睞。"},
                new MusicItem() {Name="P bass",ImageUrl= "pbass.jpg" },
                new MusicItem() {Name="P BASS（Precision-Bass）的來歷就比較講究了。 在早期沒有電貝斯的年代，貝斯手往往使用體積非常大的Double Bass，但是對市場非常敏銳的Leo Fender 本人非常富有開拓精神，在經典ST和TELE電吉他琴形的理念下設計了最早的 電貝斯型號也就是Precision-Bass，簡稱P BASS。 與晚輩 JAZZ BASS 相比 P BASS 誕生更早，而且適用風格相對更廣一般使用雙線圈拾音器音色厚重飽滿，所以經過很多年發展依然有很多樂手喜歡。"},
            };
            Earphone = new List<MusicItem>()
            {
                new MusicItem() {Name="耳塞式耳機",ImageUrl= "ear01.jpg" },
                new MusicItem() {Name="最常見的耳塞式耳機便是手機附贈的耳機，不需要侵入耳道便能牢靠的配戴，能符合大多數人的耳型，但用過的人都知道，他的隔音效果幾乎是不存在的，隔音便是耳塞式的一大硬傷，除了低頻會比較容易外洩，在嘈雜的環境使用時，通常會為了聽清楚音樂的細節，把音量往上調，容易對聽力造成損害，對於專業的舞台表演者的影響更大，但是其便利性和泛用性還是不可小覷的，畢竟身為耳塞式耳機的EARPODS可是有六億的出貨量呢～"},
                new MusicItem() {Name="耳道式耳機",ImageUrl= "ear02.jpg" },
                new MusicItem() {Name="耳道式耳機為隨身耳機的另外一種形式，就是將耳機放入耳道，並用矽膠或海綿將耳機固定在耳朵內，因此耳道式耳機通常都會有不錯的隔音效果，身處嘈雜的環境時也不用需要較大的音量來表現音樂的細節，進而保護了聽力，因此市面上較高階的隨身耳機大多採用耳道式的設計，AERO便是屬於耳道式耳機的範疇喔。"},
                new MusicItem() {Name="開放式耳機",ImageUrl= "ear03.jpg" },
                new MusicItem() {Name="開放式耳機顧名思義，就是發聲單體和外界沒有物理隔絕，內外部的聲音都會相互流通，在外殼上通常採用格柵、開孔或是透音材質，甚至有可以透過腔體看見振膜的設計。大多廠商的旗艦型號都是採用開放式的設計，除了能夠降低配戴時的壓迫感，也能夠降低腔體對於振膜的影響，進而改善單體的失真，細節通常會比較多，但開放式耳機因為不隔音的特性，對於聆聽的環境會有較高的需求，在安靜的環境下別人還可以清楚地聽到耳機內的聲音。"},
                new MusicItem() {Name="封閉式耳機",ImageUrl= "ear04.jpg" },
                new MusicItem() {Name="封閉式耳機就是相對於開放式耳機的存在，腔體呈現密閉的形式，能提供優秀的隔音性能，因此較多監聽式耳機會採用封閉式的設計。\r\n \r\n \r\n封閉和開放式耳機各有特色，但最影響耳機音質的因素，還是取決於各家廠商的設計，雖然結構能稍微改變耳機的聲音走向，不過要真正的去判斷一副耳機的好壞，還是得靠自己的雙耳去體會才行。"},
            };
            Speaker = new List<MusicItem>()
            {
                new MusicItem() {Name="電吉他音箱",ImageUrl= "speaker01.jpg" },
                new MusicItem() {Name="吉他音箱主要由前級(Per-Amp)、後級(Power Amp) 、喇叭(Speaker cabinet)三個部分所構成。 前級擴大器(Per-Amp)，負責第一階段的訊號處理，接受電子信號並將其訊號扭曲變化。 其中包含訊號的增益（gain）、各憑率的調整（音色個性）、以及效果處理（reverb）等。"},
                new MusicItem() {Name="木吉他音箱",ImageUrl= "speaker02.jpg" },
                new MusicItem() {Name="木吉他音箱有個重點 ：確認聲音。其實當你彈奏木吉他的時候，因為角度的關係你並沒有完整的聽到自己的聲音，而且你聽到的聲音跟拾音器收到的聲音並不相同，如果要成為一個好的演奏家那你必須確認自己發出來的聲音經過放大之後還是好的，因此在練習時經由音箱去確認自己的聲音也會幫助你在表演時的演奏品質。"},
                new MusicItem() {Name="貝斯音箱",ImageUrl= "speaker03.jpg" },
                new MusicItem() {Name="對於許多貝斯手來說，電晶體音箱清晰乾淨的音色比真空管音箱的溫暖色調來的更有穿透力也更方便調整，因此在貝斯音箱中並不像電吉他音箱那樣追求真空管至上。再加上電晶體輕巧且成本較低的優勢，現在許多廠商都開始朝著將體積縮小並且強化功能性發展。目前市面上已經出現了不少輕巧到可以放進琴袋裡，同時還擁有超大的輸出功率貝斯音箱頭。"},
                new MusicItem() {Name="鍵盤音箱",ImageUrl= "speaker04.jpg" },
                new MusicItem() {Name="電子琴音箱是一種專為電子琴聲音增強而設計的音響設備，具有多種特點和功能：\r\n\r\n功率和大小： 電子琴音箱的大小和功率區別明顯。大型音箱通常提供更高的功率，適合在大型場合演奏，而小型音箱則更適合家庭使用或小型表演。\r\n\r\n揚聲器配置： 可選擇單揚聲器或多揚聲器系統。多揚聲器通常區分為低音、中音和高音，以提供更豐富的音效體驗。\r\n\r\n音調調整： 音箱通常具有音調和音色調整功能，使演奏者能夠根據個人偏好微調音調和音色。\r\n\r\n效果處理： 一些音箱內建效果處理功能，例如混響、合唱和弦等，以增添音樂的層次和深度。\r\n\r\n連接性： 音箱配有各種輸入和輸出端口，使其能夠與其他音響設備，如混音器、錄音設備或耳機，實現連接。\r\n\r\n耳機輸出： 音箱通常提供耳機輸出，讓演奏者能夠在不干擾他人的情況下練習或演奏。\r\n\r\n輕巧便攜： 部分音箱設計輕便，便於攜帶，適合携帶到各種場所，如表演、排練室或家中使用。\r\n\r\n價格： 音箱價格跨足從入門級到專業級，使用者可以根據預算和需求選擇適合的型號。"},
            };
            Drum = new List<MusicItem>()
            {
                new MusicItem() {Name="爵士鼓",ImageUrl= "drum01.jpg" },
                new MusicItem() {Name="爵士鼓（英語：Drum kit、Drum set、Trap set，中國大陸多稱為架子鼓），是由一組不同音色的鼓與其他打擊樂器（通常是架在架子上的銅鈸）組成，並由單人演奏。 以雙手握鼓棒、鼓刷或束棒，雙腳踩踏板控制hi-hat與大鼓鼓搥。 因為從外觀上就像一排架子上掛著很多鼓。"},
                new MusicItem() {Name="木箱鼓",ImageUrl= "drum02.jpg" },
                new MusicItem() {Name="木箱鼓（Cajon），這個起源於秘魯的美妙樂器，它的構造簡單，就是一個木箱子，但演奏起來卻一點也不簡單。 打擊面和箱體的共鳴使它同時具備了清脆的高音與渾厚的低頻，對於製造節奏律動非常適合，同時又方便攜帶！ 所以短時間內便在世界各地流行了起來。"},
                new MusicItem() {Name="銅鈸",ImageUrl= "drum03.jpg" },
                new MusicItem() {Name="小鈸，中央鼓起，呈圓盤狀的打擊樂器，其突起中心鑿有一小孔，用於繫上布條，方便在演奏時抓握，此銅鈸兩面的小孔上皆繫有一紅色繩。 銅類樂器的製造原料主要為銅，並加入少量的錫，此類樂器屬於中國古代八音分類法中的「金」。"},
                new MusicItem() {Name="踏板",ImageUrl= "drum04.jpg" },
                new MusicItem() {Name="材質大致分為棉槌、木槌與塑膠槌三大類。 因為鼓槌是踏板中唯一與鼓皮接觸的部分，所以不同材質會直接地影響到大鼓的音色。 棉槌：音色較為溫和，力道較小，適合輕柔的曲風。 塑膠槌：音色較為高頻突出，有明顯的顆粒感，但飽滿度不足，適合快速度的曲風。"},
                new MusicItem() {Name="鼓棒",ImageUrl= "drum05.jpg" },
                new MusicItem() {Name="一般鼓棒的鼓棒頭主要可分為木頭及尼龍頭2種，木頭鼓棒敲擊的聲響較為溫和、厚實；而尼龍頭鼓棒敲擊出的聲響則較為清脆、響亮。在正常使用的情況下，尼龍頭壽命較長，但若敲擊太過猛烈，尼龍頭反而會比木頭更容易斷裂脫落。"},
                new MusicItem() {Name="鼓皮",ImageUrl= "drum06.jpg" },
                new MusicItem() {Name="鼓皮，Drum Head，Drum's Skin，鼓的皮膚。 鼓皮之於鼓，就像弦之於琴， 它是需要替換的耗材，也是決定鼓的聲音、敲擊手感的關鍵之一。 不同厚度、品質、材質的鼓皮，會影響鼓棒敲擊的反彈力、殘響/共鳴（sustain）、音色、和音量。"},
            };
            Keyboards = new List<MusicItem>()
            {
                new MusicItem() {Name="Korg電鋼琴",ImageUrl= "korg.jpg" },
                new MusicItem() {Name="Korg 電鋼琴具有出色的音色品質和演奏感。它們通常配備真實的鋼琴聲音，通過多層取樣和高級數字音源技術，以實現出色的音色細節和表現力。Korg 電子鋼琴還具有各種功能和特點，例如觸鍵靈敏度和重力回應，可模擬傳統鋼琴的觸感。一些型號還具有內置的音色庫，包含各種音色選擇，如鋼琴、管風琴、弦樂和合成器等。"},
                new MusicItem() {Name="Nord電鋼琴",ImageUrl= "nord.jpg" },
                new MusicItem() {Name="Nord 電鋼琴是另一個知名的電鋼琴品牌，提供了一系列高品質的產品。而Nord 電鋼琴以其卓越的音質、演奏感和專業級功能而受到廣泛讚譽。Nord電子鋼琴的設計也非常注重移動性和實用性。它們通常輕便且易於攜帶，適合現場演出和巡迴表演。許多Nord產品還具有直觀的使用者界面和易於操作的控制面板，使其在舞臺和錄音室中易於操作和調整。"},
                new MusicItem() {Name="Roland電鋼琴",ImageUrl= "roland.jpg" },
                new MusicItem() {Name="Roland 電鋼琴 具有出色的演奏體驗和功能。它們通常配備了鍵盤的觸感和響應度，模擬了真實鋼琴的觸感，使演奏者能夠更加細膩地表達音樂情感。許多Roland的產品還擁有多種演奏模式、音色切換、音量調節和效果處理等功能，使用戶能夠靈活地探索和定製自己的音樂風格。"},
                new MusicItem() {Name="Yanaha電鋼琴",ImageUrl= "yanaha.jpg" },
                new MusicItem() {Name="Yamaha 電鋼琴 具有出色的演奏體驗和功能性。它們的鍵盤響應度和觸感設計，強化了演奏者對音樂的表達。許多Yamaha的產品還擁有各種功能和模式，如分響分層、音色切換、音量調節和效果處理，讓使用者能夠根據需要定製和創作獨特的音樂風格。"},
            };
        }
    }
}
