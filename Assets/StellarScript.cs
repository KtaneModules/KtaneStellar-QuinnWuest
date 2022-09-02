using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using UnityEngine;
using Rnd = UnityEngine.Random;

public class StellarScript : MonoBehaviour
{
    public Transform StarTransform;
    public Material bright;
    public Material dark;
    public Material green;
    public Material red;
    public KMSelectable _button;

    private static readonly string[] Passwords = "abs|aby|ace|act|ado|ads|adz|aft|age|ago|ags|ahi|ahs|aid|ail|aim|ain|air|ais|ait|aji|alb|ale|alp|als|alt|ami|amp|amu|and|ane|ani|ant|any|ape|apo|apt|arb|arc|are|arf|ark|arm|ars|art|ash|ask|asp|ate|auk|ave|avo|awe|awl|awn|axe|aye|ays|azo|bad|bag|bah|bal|bam|ban|bap|bar|bas|bat|bay|bed|beg|bel|ben|bes|bet|bey|bid|big|bin|bio|bis|bit|biz|boa|bod|bog|bop|bos|bot|bow|box|boy|bra|bro|bud|bug|bum|bun|bur|bus|but|buy|bye|bys|cab|cad|caf|cam|can|cap|car|cat|caw|cay|cel|cep|chi|cig|cis|cob|cod|cog|col|con|cop|cor|cos|cot|cow|cox|coy|coz|cru|cry|cub|cud|cue|cup|cur|cut|cuz|cwm|dab|dag|dah|dak|dal|dam|dan|dap|das|daw|day|deb|def|del|den|dep|dev|dew|dex|dey|dib|die|dif|dig|dim|din|dip|dis|dit|doc|doe|dog|doh|dol|dom|don|dor|dos|dot|dow|dry|dub|due|dug|duh|dui|dum|dun|duo|dup|dye|ear|eat|eau|eco|ecu|edh|eds|efs|eft|ego|eld|elf|elk|elm|els|emo|ems|emu|end|eng|ens|eon|era|erg|ern|ers|est|eta|eth|fab|fad|fah|fan|far|fas|fat|fax|fay|fed|feh|fem|fen|fer|fes|fet|feu|few|fey|fez|fib|fid|fie|fig|fil|fin|fir|fit|fix|fiz|flu|fly|fob|foe|fog|foh|fon|fop|for|fou|fox|foy|fro|fry|fub|fud|fug|fun|fur|gab|gad|gae|gal|gam|gan|gap|gar|gas|gat|gay|ged|gel|gem|gen|get|gey|ghi|gib|gid|gie|gif|gin|gip|gis|git|gnu|goa|gob|god|gor|gos|got|gox|gul|gum|gun|gut|guv|guy|gym|gyp|had|hae|hag|haj|ham|hao|hap|has|hat|haw|hay|hem|hen|hep|her|hes|het|hew|hex|hey|hic|hid|hie|him|hin|hip|his|hit|hob|hod|hoe|hog|hom|hon|hop|hot|how|hoy|hub|hue|hug|hum|hun|hup|hut|hyp|ice|ich|ick|icy|ids|ifs|ilk|imp|ink|ins|ion|ire|irk|ism|its|ivy|jab|jag|jam|jar|jaw|jay|jet|jeu|jib|jig|jin|job|joe|jog|jot|jow|joy|jug|jun|jus|jut|kab|kae|kaf|kas|kat|kay|kea|kef|keg|ken|kep|kex|key|khi|kid|kif|kin|kip|kir|kis|kit|koa|kob|koi|kop|kor|kos|kue|kye|lab|lac|lad|lag|lah|lam|lap|lar|las|lat|lav|law|lax|lay|lea|led|leg|lei|lek|let|leu|lev|lex|ley|lib|lid|lie|lin|lip|lis|lit|lob|log|lop|lot|low|lox|lud|lug|lum|lun|luv|lux|lye|mac|mad|mae|mag|man|map|mar|mas|mat|maw|max|may|med|meg|meh|mel|men|met|mew|mho|mib|mic|mid|mig|mil|mir|mis|mix|moa|mob|moc|mod|mog|moi|mol|mon|mop|mor|mos|mot|mow|mud|mug|mun|mus|mut|mux|myc|nab|nae|nag|nah|nam|nap|nav|naw|nay|neb|neg|net|new|nib|nil|nim|nip|nit|nix|nob|nod|nog|noh|nom|nor|nos|not|now|nth|nub|nug|nus|nut|oaf|oak|oar|oat|oba|obe|obi|oca|och|oda|ode|ods|oes|oft|ohm|ohs|oik|oil|oka|oke|old|ole|oma|oms|one|ons|opa|ope|ops|opt|ora|orb|orc|ore|org|ors|ort|ose|oud|our|out|ova|owe|owl|own|owt|oxy|pac|pad|pah|pak|pal|pam|pan|par|pas|pat|paw|pax|pay|pea|pec|ped|peg|peh|pen|per|pes|pet|pew|phi|pho|pht|pia|pic|pie|pig|pin|pis|pit|piu|pix|ply|pod|poh|poi|pol|pom|pos|pot|pow|pox|pro|pry|psi|pst|pub|pud|pug|pul|pun|pur|pus|put|pya|pye|pyx|qat|qis|qua|rad|rag|rah|rai|raj|ram|ran|rap|ras|rat|raw|rax|ray|reb|rec|red|ref|reg|rei|rem|rep|res|ret|rev|rex|rez|rho|ria|rib|rid|rif|rig|rim|rin|rip|rob|roc|rod|roe|rom|rot|row|rub|rue|rug|rum|run|rut|rya|rye|ryu|sab|sac|sad|sae|sag|sal|san|sap|sat|sau|saw|sax|say|sea|sec|seg|sei|sel|sen|ser|set|sev|sew|sex|sha|she|sho|shy|sib|sic|sig|sim|sin|sip|sir|sit|six|ska|ski|sky|sly|sob|soc|sod|soh|sol|som|son|sop|sot|sou|sow|sox|soy|spa|spy|sri|sty|sub|sue|suk|sum|sun|sup|suq|syn|tab|tad|tae|tag|taj|tam|tan|tao|tap|tar|tas|tau|tav|taw|tax|tea|tec|ted|teg|tel|ten|tes|tew|the|tho|thy|tic|tie|til|tin|tip|tis|tix|tiz|tod|toe|tog|tom|ton|top|tor|tow|toy|try|tsk|tub|tug|tui|tum|tun|tup|tux|twa|two|tye|udo|ugh|uke|ump|ums|uni|uns|upo|ups|urb|urd|urn|urp|use|uta|ute|uts|vac|van|var|vas|vat|vau|vaw|veg|vet|vex|via|vid|vie|vig|vim|vin|vis|voe|vog|vow|vox|vug|vum|wab|wad|wae|wag|wan|wap|war|was|wat|wax|way|web|wed|wen|wet|wha|who|why|wig|win|wis|wit|wiz|woe|wok|won|wos|wot|wry|wud|wye|wyn|xis|yag|yah|yak|yam|yap|yar|yas|yaw|yea|yeh|yen|yep|yes|yet|yew|yin|yip|yob|yod|yok|yom|yon|you|yow|yuk|yum|yup|zag|zap|zas|zax|zed|zek|zen|zep|zig|zin|zip|zit|zoa".Split(new char[] { '|' });
    private bool _isSolved;
    private int _id;
    private static int _idc;
    private float _pushTime;
    private Coroutine pulse;
    private static readonly Dictionary<char, bool[]> Braille = "abcdefghijklmnopqrstuvwxyz".ToDictionary((char c) => c, delegate (char c)
    {
        switch (c)
        {
            case 'a':
                return new bool[]
                {
                true,
                false,
                false,
                false,
                false,
                false
                };
            case 'b':
                return new bool[]
                {
                true,
                true,
                false,
                false,
                false,
                false
                };
            case 'c':
                return new bool[]
                {
                true,
                false,
                false,
                true,
                false,
                false
                };
            case 'd':
                return new bool[]
                {
                true,
                false,
                false,
                true,
                true,
                false
                };
            case 'e':
                return new bool[]
                {
                true,
                false,
                false,
                false,
                true,
                false
                };
            case 'f':
                return new bool[]
                {
                true,
                true,
                false,
                true,
                false,
                false
                };
            case 'g':
                return new bool[]
                {
                true,
                true,
                false,
                true,
                true,
                false
                };
            case 'h':
                return new bool[]
                {
                true,
                true,
                false,
                false,
                true,
                false
                };
            case 'i':
                return new bool[]
                {
                false,
                true,
                false,
                true,
                false,
                false
                };
            case 'j':
                return new bool[]
                {
                false,
                true,
                false,
                true,
                true,
                false
                };
            case 'k':
                return new bool[]
                {
                true,
                false,
                true,
                false,
                false,
                false
                };
            case 'l':
                return new bool[]
                {
                true,
                true,
                true,
                false,
                false,
                false
                };
            case 'm':
                return new bool[]
                {
                true,
                false,
                true,
                true,
                false,
                false
                };
            case 'n':
                return new bool[]
                {
                true,
                false,
                true,
                true,
                true,
                false
                };
            case 'o':
                return new bool[]
                {
                true,
                false,
                true,
                false,
                true,
                false
                };
            case 'p':
                return new bool[]
                {
                true,
                true,
                true,
                true,
                false,
                false
                };
            case 'q':
                return new bool[]
                {
                true,
                true,
                true,
                true,
                true,
                false
                };
            case 'r':
                return new bool[]
                {
                true,
                true,
                true,
                false,
                true,
                false
                };
            case 's':
                return new bool[]
                {
                false,
                true,
                true,
                true,
                false,
                false
                };
            case 't':
                return new bool[]
                {
                false,
                true,
                true,
                true,
                true,
                false
                };
            case 'u':
                return new bool[]
                {
                true,
                false,
                true,
                false,
                false,
                true
                };
            case 'v':
                return new bool[]
                {
                true,
                true,
                true,
                false,
                false,
                true
                };
            case 'w':
                return new bool[]
                {
                false,
                true,
                false,
                true,
                true,
                true
                };
            case 'x':
                return new bool[]
                {
                true,
                false,
                true,
                true,
                false,
                true
                };
            case 'y':
                return new bool[]
                {
                true,
                false,
                true,
                true,
                true,
                true
                };
            case 'z':
                return new bool[]
                {
                true,
                false,
                true,
                false,
                true,
                true
                };
            default:
                return new bool[6];
        }
    });
    private static readonly Dictionary<char, bool[]> MorseCode = "abcdefghijklmnopqrstuvwxyz".ToDictionary((char c) => c, delegate (char c)
    {
        switch (c)
        {
            case 'a':
                return new bool[]
                {
                true,
                false,
                true,
                true,
                true
                };
            case 'b':
                return new bool[]
                {
                true,
                true,
                true,
                false,
                true,
                false,
                true,
                false,
                true
                };
            case 'c':
                return new bool[]
                {
                true,
                true,
                true,
                false,
                true,
                true,
                true,
                false,
                true,
                false,
                true
                };
            case 'd':
                return new bool[]
                {
                true,
                true,
                true,
                false,
                true,
                false,
                true
                };
            case 'e':
                return new bool[]
                {
                true
                };
            case 'f':
                return new bool[]
                {
                true,
                false,
                true,
                false,
                true,
                true,
                true,
                false,
                true
                };
            case 'g':
                return new bool[]
                {
                true,
                true,
                true,
                false,
                true,
                true,
                true,
                false,
                true
                };
            case 'h':
                return new bool[]
                {
                true,
                false,
                true,
                false,
                true,
                false,
                true
                };
            case 'i':
                return new bool[]
                {
                true,
                false,
                true
                };
            case 'j':
                return new bool[]
                {
                true,
                false,
                true,
                true,
                true,
                false,
                true,
                true,
                true,
                false,
                true,
                true,
                true
                };
            case 'k':
                return new bool[]
                {
                true,
                true,
                true,
                false,
                true,
                false,
                true,
                true,
                true
                };
            case 'l':
                return new bool[]
                {
                true,
                false,
                true,
                true,
                true,
                false,
                true,
                false,
                true
                };
            case 'm':
                return new bool[]
                {
                true,
                true,
                true,
                false,
                true,
                true,
                true
                };
            case 'n':
                return new bool[]
                {
                true,
                true,
                true,
                false,
                true
                };
            case 'o':
                return new bool[]
                {
                true,
                true,
                true,
                false,
                true,
                true,
                true,
                false,
                true,
                true,
                true
                };
            case 'p':
                return new bool[]
                {
                true,
                false,
                true,
                true,
                true,
                false,
                true,
                true,
                true,
                false,
                true
                };
            case 'q':
                return new bool[]
                {
                true,
                true,
                true,
                false,
                true,
                true,
                true,
                false,
                true,
                false,
                true,
                true,
                true
                };
            case 'r':
                return new bool[]
                {
                true,
                false,
                true,
                true,
                true,
                false,
                true
                };
            case 's':
                return new bool[]
                {
                true,
                false,
                true,
                false,
                true
                };
            case 't':
                return new bool[]
                {
                true,
                true,
                true
                };
            case 'u':
                return new bool[]
                {
                true,
                false,
                true,
                false,
                true,
                true,
                true
                };
            case 'v':
                return new bool[]
                {
                true,
                false,
                true,
                false,
                true,
                false,
                true,
                true,
                true
                };
            case 'w':
                return new bool[]
                {
                true,
                false,
                true,
                true,
                true,
                false,
                true,
                true,
                true
                };
            case 'x':
                return new bool[]
                {
                true,
                true,
                true,
                false,
                true,
                false,
                true,
                false,
                true,
                true,
                true
                };
            case 'y':
                return new bool[]
                {
                true,
                true,
                true,
                false,
                true,
                false,
                true,
                true,
                true,
                false,
                true,
                true,
                true
                };
            case 'z':
                return new bool[]
                {
                true,
                true,
                true,
                false,
                true,
                true,
                true,
                false,
                true,
                false,
                true
                };
            default:
                return new bool[6];
        }
    });
    private static readonly Dictionary<char, int[]> TapCode = "abcdefghijklmnopqrstuvwxyz".ToDictionary((char c) => c, delegate (char c)
    {
        switch (c)
        {
            case 'a':
                return new int[]
                {
                1,
                1
                };
            case 'b':
                return new int[]
                {
                1,
                2
                };
            case 'c':
                return new int[]
                {
                1,
                3
                };
            case 'd':
                return new int[]
                {
                1,
                4
                };
            case 'e':
                return new int[]
                {
                1,
                5
                };
            case 'f':
                return new int[]
                {
                2,
                1
                };
            case 'g':
                return new int[]
                {
                2,
                2
                };
            case 'h':
                return new int[]
                {
                2,
                3
                };
            case 'i':
                return new int[]
                {
                2,
                4
                };
            case 'j':
                return new int[]
                {
                2,
                5
                };
            case 'k':
                return new int[]
                {
                1,
                3
                };
            case 'l':
                return new int[]
                {
                3,
                1
                };
            case 'm':
                return new int[]
                {
                3,
                2
                };
            case 'n':
                return new int[]
                {
                3,
                3
                };
            case 'o':
                return new int[]
                {
                3,
                4
                };
            case 'p':
                return new int[]
                {
                3,
                5
                };
            case 'q':
                return new int[]
                {
                4,
                1
                };
            case 'r':
                return new int[]
                {
                4,
                2
                };
            case 's':
                return new int[]
                {
                4,
                3
                };
            case 't':
                return new int[]
                {
                4,
                4
                };
            case 'u':
                return new int[]
                {
                4,
                5
                };
            case 'v':
                return new int[]
                {
                5,
                1
                };
            case 'w':
                return new int[]
                {
                5,
                2
                };
            case 'x':
                return new int[]
                {
                5,
                3
                };
            case 'y':
                return new int[]
                {
                5,
                4
                };
            case 'z':
                return new int[]
                {
                5,
                5
                };
            default:
                return new int[2];
        }
    });
    private string lastPlayed = "---";
    private int playedCount;
    private bool playing;

    private void Log(string message)
    {
        Debug.LogFormat("[Stellar #{0}] {1}", new object[] { _id, message });
    }

    private void PlaySound(string soundName)
    {
        GetComponent<KMAudio>().PlaySoundAtTransform(soundName, StarTransform);
    }

    private void Start()
    {
        _id = ++_idc;
        StartCoroutine(RandomRotation());
        _button.OnInteract += delegate ()
        {
            Push();
            _button.AddInteractionPunch(1f);
            return false;
        };
        _button.OnInteractEnded += delegate ()
        {
            PushOff();
        };
    }

    private Vector3 _currentTransform;

    private IEnumerator RandomRotation()
    {
        while (true)
        {
            _currentTransform = new Vector3(StarTransform.localEulerAngles.x, StarTransform.localEulerAngles.y, StarTransform.localEulerAngles.z);
            var duration = 0.3f;
            var elapsed = 0f;
            var randX = _currentTransform.x + Rnd.Range(10f, 40f) * (Rnd.Range(0, 2) == 0 ? -1f : 1f);
            var randY = _currentTransform.y + Rnd.Range(10f, 40f) * (Rnd.Range(0, 2) == 0 ? -1f : 1f);
            var randZ = _currentTransform.z + Rnd.Range(10f, 40f) * (Rnd.Range(0, 2) == 0 ? -1f : 1f);
            while (elapsed < duration)
            {
                StarTransform.localEulerAngles = new Vector3(
                    Mathf.Lerp(_currentTransform.x, randX, elapsed / duration),
                    Mathf.Lerp(_currentTransform.y, randY, elapsed / duration),
                    Mathf.Lerp(_currentTransform.z, randZ, elapsed / duration)
                    );
                yield return null;
                elapsed += Time.deltaTime;
            }
            StarTransform.localEulerAngles = new Vector3(randX, randY, randZ);
            yield return null;
        }
    }

    private void Push()
    {
        if (_isSolved)
            return;
        _pushTime = Time.time;
        pulse = StartCoroutine(Pulse());
    }

    private IEnumerator Pulse()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.9f);
            StarTransform.GetComponent<MeshRenderer>().material = bright;
            yield return new WaitForSeconds(0.1f);
            StarTransform.GetComponent<MeshRenderer>().material = dark;
        }
    }

    private void PushOff()
    {
        if (_isSolved)
            return;
        StopCoroutine(pulse);
        if (Time.time - _pushTime < 1f)
            StartCoroutine(PlayCodes());
        else
            Submit(Mathf.FloorToInt(Time.time - _pushTime));
    }

    private void Submit(int time)
    {
        if (lastPlayed == "---")
        {
            Log("That was incorrect, you didn't even see what I had to say. You have struck.");
            GetComponent<KMBombModule>().HandleStrike();
            StartCoroutine(Red());
            return;
        }
        int num = ("abcdefghijklmnopqrstuvwxyz".IndexOf(lastPlayed[0]) + 1 + "abcdefghijklmnopqrstuvwxyz".IndexOf(lastPlayed[1]) + 1 + "abcdefghijklmnopqrstuvwxyz".IndexOf(lastPlayed[2]) + 1) % 10 + 2;
        if (time == num)
        {
            StarTransform.GetComponent<MeshRenderer>().material = green;
            PlaySound("Solve");
            Log("Good job, that was correct.");
            GetComponent<KMBombModule>().HandlePass();
            _isSolved = true;
        }
        else
        {
            Log(string.Format("That was incorrect, you should have submitted {0} but you sumitted {1}. You have struck.", num, time));
            GetComponent<KMBombModule>().HandleStrike();
            StartCoroutine(Red());
        }
    }

    private IEnumerator Red()
    {
        StarTransform.GetComponent<MeshRenderer>().material = red;
        yield return new WaitForSeconds(0.7f);
        StarTransform.GetComponent<MeshRenderer>().material = dark;
        yield break;
    }

    private IEnumerator PlayCodes()
    {
        if (playing)
        {
            yield break;
        }
        playing = true;
        if (lastPlayed == "---" || playedCount >= 2)
        {
            lastPlayed = Passwords.PickRandom();
            playedCount = 0;
        }
        Log(string.Format("You asked me to play a word, and I chose \"{0}\".", lastPlayed));
        int num = ("abcdefghijklmnopqrstuvwxyz".IndexOf(lastPlayed[0]) + 1 + "abcdefghijklmnopqrstuvwxyz".IndexOf(lastPlayed[1]) + 1 + "abcdefghijklmnopqrstuvwxyz".IndexOf(lastPlayed[2]) + 1) % 10 + 2;
        Log(string.Format("You should submit {0} as your answer.", num));
        StartCoroutine(PlayTapCode(lastPlayed[1]));
        StartCoroutine(PlayMorseCode(lastPlayed[2]));
        foreach (bool b in Braille[lastPlayed[0]])
        {
            StartCoroutine(BraillePulse(b));
            yield return new WaitForSeconds(1f);
        }
        StarTransform.localScale = new Vector3(0.3f, 0.3f, 0.3f);
        playedCount++;
        playing = false;
        yield break;
    }

    private IEnumerator BraillePulse(bool pulseOut)
    {
        float duration = 0.25f;
        float elapsed = 0f;
        float goalScale = pulseOut ? 0.375f : 0.225f;
        while (elapsed < duration)
        {
            StarTransform.localScale = new Vector3(Easing.InOutQuad(elapsed, 0.3f, goalScale, duration), Easing.InOutQuad(elapsed, 0.3f, goalScale, duration), Easing.InOutQuad(elapsed, 0.3f, goalScale, duration));
            yield return null;
            elapsed += Time.deltaTime;
        }
        elapsed = 0f;
        while (elapsed < duration)
        {
            StarTransform.localScale = new Vector3(Easing.InOutQuad(elapsed, goalScale, 0.3f, duration), Easing.InOutQuad(elapsed, goalScale, 0.3f, duration), Easing.InOutQuad(elapsed, goalScale, 0.3f, duration));
            yield return null;
            elapsed += Time.deltaTime;
        }
        StarTransform.localScale = new Vector3(0.3f, 0.3f, 0.3f);
    }

    private IEnumerator PlayMorseCode(char p)
    {
        bool[] play = MorseCode[p].Concat(Enumerable.Repeat(false, 12)).ToArray();
        for (int i = 0; i < 13; i++)
        {
            if (play[i])
                StarTransform.GetComponent<MeshRenderer>().material = bright;
            else
                StarTransform.GetComponent<MeshRenderer>().material = dark;
            yield return new WaitForSeconds(0.46153846f);
        }
        StarTransform.GetComponent<MeshRenderer>().material = dark;
        yield break;
    }

    private IEnumerator PlayTapCode(char p)
    {
        for (int i = 0; i < TapCode[p][0]; i++)
        {
            PlaySound("TPCD");
            yield return new WaitForSeconds(0.8f - ((TapCode[p][1] - 1) * 0.075f));
        }
        for (int j = 0; j < TapCode[p][1]; j++)
        {
            PlaySound("TPCD2");
            yield return new WaitForSeconds(0.8f - ((TapCode[p][1] - 1) * 0.075f));
        }
        yield break;
    }
#pragma warning disable 0414
    private readonly string TwitchHelpMessage = "Use '!{0} tap' to tap the module. Use '!{0} hold 3' to hold the module for 3 pulses.";
#pragma warning restore 0414

    private IEnumerator ProcessTwitchCommand(string command)
    {
        if (Regex.IsMatch(command.Trim().ToLowerInvariant(), @"^\s*tap\s*$", RegexOptions.IgnoreCase | RegexOptions.CultureInvariant))
        {
            yield return null;
            _button.OnInteract.Invoke();
            _button.OnInteractEnded();
        }
        else
        {
            var m = Regex.Match(command.Trim().ToLowerInvariant(), @"^\s*hold\s+(\\d{1,2})\s*$", RegexOptions.IgnoreCase | RegexOptions.CultureInvariant);
            if (!m.Success)
                yield break;
            int c;
            if (!int.TryParse(m.Groups[1].Value, out c) || c > 11)
                yield break;
            yield return null;
            _button.OnInteract.Invoke();
            yield return new WaitForSeconds(0.5f + c);
            _button.OnInteractEnded();
        }
        yield break;
    }

    private IEnumerator TwitchHandleForcedSolve()
    {
        if (lastPlayed == "---")
        {
            _button.OnInteract.Invoke();
            _button.OnInteractEnded();
        }
        while (playing)
            yield return true;
        int ans = ("abcdefghijklmnopqrstuvwxyz".IndexOf(lastPlayed[0]) + 1 + "abcdefghijklmnopqrstuvwxyz".IndexOf(lastPlayed[1]) + 1 + "abcdefghijklmnopqrstuvwxyz".IndexOf(lastPlayed[2]) + 1) % 10 + 2;
        _button.OnInteract.Invoke();
        yield return new WaitForSeconds(ans + 0.5f);
        _button.OnInteractEnded();
        yield break;
    }


}