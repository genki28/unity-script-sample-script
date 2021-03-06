public abstract class CsvData
{
    // ÇÝñ¾csvf[^Ìo^
    public abstract void SetData(string[] data);

    // ÔoðpxÉÏ·
    public float RightAscensionToDegree(int hour, int min = 0, float sec = 0.0f)
    {
        var h = 360.0f / 24.0f;
        var m = h / 60.0f;
        var s = m / 60.0f;

        return (h * hour + m * min + s * sec) * -1.0f;
    }

    // ÔÜðpxÉÏ·
    public float DeclinationToDegree(int deg, int min = 0, float sec = 0.0f)
    {
        var plusMinus = 1.0f;
        if (deg < 0.0f)
        {
            plusMinus = -1.0f;
            deg *= -1;
        }
        return DeclinationToDegree(plusMinus, deg, min, sec);
    }

    // ÔÜðpxÉÏ·
    public float DeclinationToDegree(float plusMinus, int deg, int min = 0, float sec = 0.0f)
    {
        return (deg * plusMinus + min / 60.0f * plusMinus + sec / (60.0f * 60.0f) * plusMinus) * -1.0f;
    }
}