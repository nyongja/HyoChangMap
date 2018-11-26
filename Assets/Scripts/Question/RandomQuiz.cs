using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomQuiz : MonoBehaviour
{
    public Touch_Flower tf;
    
    public FlowerEmerge fe;

    public Canvas rgc;//regameCanvas
    public Canvas rcv;//retry Canvas
    public Canvas qc;//questioni canvas
    public Canvas rc; //right Canvas
    public Canvas gc; //getCanvas
    public Canvas wc; //wrong Canvas
    public Text qt;//questionText
    public Text rt;//rightText
    public Text wt;//wrongText

    bool bgmplay = true;
    public RawImage flowerflag1;
    public RawImage flowerflag2;
    public RawImage flowerflag3;
    public RawImage flowerflag4;
    public RawImage flowerflag5;

    public AudioSource rightsound;
    public AudioSource wrongsound;
    public RawImage dialog1;
    public RawImage dialog2;
    public RawImage dialog3;
    public RawImage dialog4;
    public Canvas dc;//dialog Canvas
    
    public RawImage right;
    public RawImage wrong;
    public RawImage getBtn;
    public RawImage nextBtn;

    public RawImage retryBtn;
    public RawImage moveBtn;

    int num = 0;
    public bool qlock = false;

    GameObject flower;

    public int right_num = 0;       //정답 맞춘 개수
    bool answerb;                   //정답 체크
    public bool getff = false;
    public bool next = false;
    public bool checkAnswer;
    float time = 0f;
    float move_time = 0f;
    public bool respond = false;
    string[] quiz = {"효창공원의 원래 명칭은 효창원이다.", "효창공원은 독립운동가들의 정신을 기리고 있다.","일제강점기 효창공원은 일본에 의해 수난을 겪었다.",
        "효창공원에 묻힌 독립운동가는 8명이다.","삼의사는 이봉창, 윤봉길, 백정기 의사를 일컫는다.",
        "이봉창 의사는 1932년 도쿄에서 일왕 히로히토에게 수류탄을 투척했다.","이봉창 의사는 1932년 도쿄에서 일왕 히로히토에게 수류탄을 투척해 암살에 성공했다.",
    "이봉창 의사는 서울 용산 출신이다.","이봉창 의사의  유해는 효창공원 안의 삼의사묘에 안장되어 있다.",
    "이봉창 의사의 생가 터는 용산구 효창동에 있다.","윤봉길 의사는 상하이 홍커우 공원에서 열린 일왕의 생일 축하 겸 일본의 전승 기념식장에 폭탄을 던졌다.",
    "상하이 홍커우 공원에서 열린 일왕의 생일 축하 겸 일본의 전승 기념 축하식 단상에 폭탄을 던진 인물은 이봉창 의사이다.","윤봉길 의사의 유해는 효창공원 안의 삼의사묘에 안장되어 있다.",
    "백정기 의사는 일본 군사시설을 파괴하는 등의 항일운동을 전개하였다.","백정기 의사는 상하이 홍커우 육삼정 연회에서 폭탄을 던져 일본군 수뇌 암살에 성공했다.",
    "백정기 의사의 유해는 효창공원 안의 삼의사묘에 안장되어 있다.","안중근 의사는 만주 하얼빈에서 침략의 원흉인 이토 히로부미를 사살하고 뤼순 감옥에서 순국하였다.","안중근 의사의 유해는 효창공원에 안장되어 있다.",
    "안중근 의사는 동지들과 죽음으로써 구국투쟁을 벌일 것을 손가락을 끊어 맹세하였다.","대한민국 임시 정부를 이끈 독립운동가로, 항일무력활동을 위한 한인애국단을 조직한 인물은 백범 김구 선생이다.",
    "백범 김구의 주선으로 이봉창, 윤봉길, 백정기의사의 묘역이 효창공원에 봉환되고 안장되었다."};

    bool[] answer = { true, true, true, false, true, true, false, true, true, true,true, false, true, true, false, true, true, false, true, true, true}; //정답

    bool[] check = { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false };   //나왔던 문제인지 체크

    public int[] countWrong = { 0, 0, 0, 0, 0, 0, 0 };     //틀린 개수 (3번 틀리면 그 스팟에서 문제 못 품)

    string[] explain = { "효창공원은 조선 22대 왕 정조의 맏아들인 문효세자의 무덤이 있어 효창원이라 불렸다.", "1946년 해방 이후 백범 김구 선생이 독립운동가들을 직접 효창공원으로 안장시키면서 효창공원은 독립운동가들의 숭고한 정신을 기리는 공간이 되었다.",
    "조선 왕실의 묘역이었던 효창공원은 일제강점기에 민족말살정책의 일환으로 일반 공원으로 전락했다.", "효창공원에는 임시정부의 김구, 이동녕, 차이석, 조성환과 윤봉길, 이봉창, 백정기 총 7명의 애국지사들이 안장되어 있다. 안중근 의사는 유해가 발견되지 않아 가묘만 존재한다.",
    "조국 광복을 위해 몸 바친 이봉창, 윤봉길, 백정기 의사를 삼의사라 일컫는다.","한인 애국단의 단원이었던 이봉창 의사는 관병식을 마치고 돌아가던 일와 히로히토를 겨냥하여 수류탄을 던져 우리의 독립의지를 보여 주었다.",
    "한인 애국단의 일원이었던 이봉창 의사는 관병식을 마치고 돌아가던 일왕 히로히토를 겨냥하여 수류탄을 던졌지만, 히로히토는 다치지 않아 거사는 실패로 돌아갔다.","이봉창 의사는 서울 용산 출신으로 그의 생가 터는 효창동 118의 1번지이다.",
    "조국 광복을 위해 몸 바친 이봉창 의사는 백범 김구 선생의 주선으로 삼의사묘에 봉환‧안장되었다.","이봉창 의사는 서울 용산 출신으로 그의 생가 터는 효창동 118의 1번지에 있다.",
    "한인 애국단의 단원이었던 윤봉길 의사는 1932년 홍커우 공원에서 열린 일본의 전승축하기념식에 폭탄을 던졌다. 이때 일본인 고관을 살상하여 우리의 독립의지를 보였다.", "상하이 홍커우 공원에서 열린 일왕의 생일 축하 겸 일본의 전승 기념 축하식 단상에 폭탄을 던진 인물은 윤봉길 의사이다.",
    "조국 광복을 위해 몸 바친 윤봉길 의사는 백범 김구 선생의 주선으로 삼의사묘에 봉환‧안장되었다.","백정기 의사는 3‧1운동 이후 상하이로 건너가 노동자 운동과 일본 상품 배격 운동을 이끌었고, 일본 시설물 파괴 공작과 요인 사살, 친일파 숙청 등을 목표로 항일 운동을 전개하였다.",
    "백정기 의사는 1933년 상하이 홍커우 육삼정 연회에 참가한 일본 주중 공사 아리요시를 습격하려다 잡혀 일본 나가사키 법원에서 무기형을 선고받고 복역하였다.","조국 광복을 위해 몸 바친 백정기 의사는 백범 김구 선생의 주선으로 삼의사묘에 봉환‧안장되었다.","안중근 의사는 1909년 만주 하얼빈역에서 대한의 독립주권을 침탈한 원흉인 이토 히로부미를 세발의 총탄으로 사살하였다",
    "중국 뤼순 감옥에서 순국한 안중근 의사의 유해는 찾으려 노력했지만 아직 찾지 못하였다. 효창공원 안의 삼의사묘에는 유해를 찾으면 안장하고자 마련한 빈 무덤이 있다.","안중근 의사를 포함한 항일투사 12명은 왼손 넷째 손가락 첫 관절을 잘라 태극기에 ‘대한 독립’을 쓰며 독립운동을 맹세하였다.",
    "백범 김구 선생은 대한민국 임시 정부를 이끈 독립운동가로 1931년에는 한인 애국단을 조직하기도 하였다. 광복 이후에는 통일 국가 수립을 위해 남북 협상에 참여하였다. ","백범 김구 선생은 일본에서 운구해온 윤봉길, 이봉창, 백정기 세 의사의 유골을 첫 국민장으로 효창공원에 손수 봉안하였다."};
    // Use this for initialization
    void Start()
    {
        rgc.gameObject.SetActive(false);
        nextBtn.gameObject.SetActive(false);
        rcv.gameObject.SetActive(false);
        qc.gameObject.SetActive(false);
        rc.gameObject.SetActive(false);
        dc.gameObject.SetActive(false);
        wc.gameObject.SetActive(false);
        gc.gameObject.SetActive(false);
        dialog1.gameObject.SetActive(false);
        dialog2.gameObject.SetActive(false);
        dialog3.gameObject.SetActive(false);
        dialog4.gameObject.SetActive(false);
        flowerflag1.gameObject.SetActive(false);
        flowerflag2.gameObject.SetActive(false);
        flowerflag3.gameObject.SetActive(false);
        flowerflag4.gameObject.SetActive(false);
        flowerflag5.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if ( fe.wrong == 3)
        {
            qc.gameObject.SetActive(false);
            rc.gameObject.SetActive(false);
            dc.gameObject.SetActive(true);
            rgc.gameObject.SetActive(true);
            dialog2.gameObject.SetActive(false);
            dialog3.gameObject.SetActive(false);
            dialog4.gameObject.SetActive(false);
            dialog1.gameObject.SetActive(false);
            dialog2.gameObject.SetActive(false);
            dialog3.gameObject.SetActive(false);
            dialog4.gameObject.SetActive(true);
        }
        if (tf.is_touch)        //꽃 눌려지면
        {
            if (qlock)  //문제 나오기 가능
            {     //문제등장
                qc.gameObject.SetActive(true);
                //문제 이상하게 나오는거 방지
               
                right.gameObject.SetActive(true);
                wrong.gameObject.SetActive(true);
                System.Random random = new System.Random();
                num = random.Next(0, quiz.Length);
                if (!check[num])            //아직 나오지않은 문제면
                {
                    Text t = qt.GetComponent<Text>();
                    check[num] = true;              //나온 문제로 check
                    answerb = answer[num];          //정답 true/false
                    t.text = quiz[num];             //문제
                    qlock = false;          //문제 반복되지않도록 qlock끄기
                }

            }
        }

        if (respond)//답을 고른 경우
        {
            if (answerb == checkAnswer)//정답
            {
                if (bgmplay)
                {
                    rightsound.GetComponent<AudioSource>().Play();
                    bgmplay = false;
                }
                qc.gameObject.SetActive(false);
                rc.gameObject.SetActive(true);
                rcv.gameObject.SetActive(false);        //Retry canvas
                Text t = rt.GetComponent<Text>();
                t.text = explain[num];

                if (getff)      //꽃 줍기
                {
                    rc.gameObject.SetActive(false);         //문제 canvas
                    gc.gameObject.SetActive(true);   //꽃잎획득 canvas
                    switch (right_num){
                        case 0:
                            flowerflag1.gameObject.SetActive(true);
                            break;
                        case 1:
                            flowerflag2.gameObject.SetActive(true);
                            break;
                        case 2:
                            flowerflag3.gameObject.SetActive(true);
                            break;
                        case 3:
                            flowerflag4.gameObject.SetActive(true);
                            break;

                    }
                    time += Time.deltaTime;
                    if (time > 1.5f)
                    {
                        switch (right_num)
                        {
                            case 0:
                                flowerflag1.gameObject.SetActive(false);
                                break;
                            case 1:
                                flowerflag2.gameObject.SetActive(false);
                                break;
                            case 2:
                                flowerflag3.gameObject.SetActive(false);
                                break;
                            case 3:
                                flowerflag4.gameObject.SetActive(false);
                                break;


                        }
                        getff = false;
                        right_num++;            //정답개수
                        Debug.Log(right_num);
                        respond = false;        //대답여부
                        bgmplay = true;
                        gc.gameObject.SetActive(false);
                        time = 0f;
                    }
                }

                

            }
            else //오답
            {
                if (bgmplay)
                {
                    wrongsound.GetComponent<AudioSource>().Play();
                    bgmplay = false;
                }
                qc.gameObject.SetActive(false);
                wc.gameObject.SetActive(true);
                nextBtn.gameObject.SetActive(true);
                Text t = wt.GetComponent<Text>();
                t.text = explain[num];

                if (next)
                {
                    wc.gameObject.SetActive(false);
                    
                    
                    if (countWrong[fe.spotNum] < 2)     //다른장소에서 풀어보겠소?
                    {       //재도전 
                        rcv.gameObject.SetActive(true);     //Retry Canvas(다시도전)
                        dc.gameObject.SetActive(true);
                        dialog1.gameObject.SetActive(true);
                        dialog2.gameObject.SetActive(false);
                        dialog3.gameObject.SetActive(false);
                        dialog4.gameObject.SetActive(false);

                        countWrong[fe.spotNum]++;
                        retryBtn.gameObject.SetActive(true);
                        moveBtn.gameObject.SetActive(true);
                        next = false;
                        nextBtn.gameObject.SetActive(false);
                        respond = false;
                        bgmplay = true;
                    }
                    else
                    {//안타깝지만 여기서는 더이상..
                        dc.gameObject.SetActive(true);
                        dialog1.gameObject.SetActive(false);
                        dialog2.gameObject.SetActive(true);
                        dialog3.gameObject.SetActive(false);
                        dialog4.gameObject.SetActive(false);

                        tf.is_touch = false;        //꽃 다시 선택가능하도록(다른 위치 꽃)
                        if (move_time < 1.5f)
                        {
                            move_time += Time.deltaTime;
                        }else {
                            dc.gameObject.SetActive(false);
                            rcv.gameObject.SetActive(false);}
                    }

                }

            }



        }
    }
}
