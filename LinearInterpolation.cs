class LinearInterpolation
{
    public void Main()
    {
        // 시작 점과 끝 점 정의
        Vector startPoint = new Vector(0, 0);
        Vector endPoint = new Vector(10, 10);
        float duration = 2.0f; // 이동 시간 (초)

        // 보간 비율 초기화
        float t = 0.0f;
        int frameRate = 30; // 프레임 속도 설정 (FPS)

        // 루프 시작
        while (t <= 1.0f)
        {
            // 선형 보간 계산
            Vector currentPosition = Lerp(startPoint, endPoint, t);
            Console.WriteLine($"{currentPosition.X}");

            // t 업데이트
            t += (1.0f / frameRate) / duration;

            // 프레임 대기
            Thread.Sleep(1000 / frameRate);
        }
    }

    // 선형 보간 메서드
    Vector Lerp(Vector a, Vector b, float t)
    {
        float x = (1 - t) * a.X + t * b.X;
        float y = (1 - t) * a.Y + t * b.Y;
        return new Vector(x, y);
    }
    
    // 벡터 클래스 정의
    class Vector
    {
        public float X { get; }
        public float Y { get; }

        public Vector(float x, float y)
        {
            X = x;
            Y = y;
        }
    }
}

