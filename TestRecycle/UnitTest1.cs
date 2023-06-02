namespace TestRecycle;
using Recycle;

    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void T_001_ScanPhoto_BaseFlow()
        {
            //подготовка данных
            Double UserLatitude = 41.343464;
            Double UserLongitude = 64.353;
            String Photo = "fgvreyetuj45";
            

            bool position = true;
            bool loading = true;
            int camera = 2;
            bool netStatus = true;
            int sign = 2;

            //ожидаемое значение
            String expectedReturnValue = "Success";
            //подготовка переменной для полученного значения
            String actualReturnValue = "Fail";
            //Assert для получения исключения
        Assert.DoesNotThrow(() =>
            {
                actualReturnValue = ScanForm.ScanPhoto(UserLatitude, UserLongitude, Photo,
                                                       position, loading, camera, netStatus, sign);
            });
            //Assert для проверки ожидаемого и полученного значения
            Assert.That(actualReturnValue, Is.EqualTo(expectedReturnValue));
    }

        [Test]
        public void T_002_ScanPhoto_PositionFail()
        {
            //подготовка данных
            Double UserLatitude = 0;
            Double UserLongitude = 0;
            String Photo = "sthrt4563dh";
        bool position = false;
        bool loading = true;
        int camera = 2;
        bool netStatus = true;
        int sign = 2;

        //ожидаемое значение
        String expectedReturnValue = "Failed to determine position";
        //подготовка переменной для полученного значения
        String actualReturnValue = "Fail";
        //Assert для получения исключения
        Assert.DoesNotThrow(() =>
        {
            actualReturnValue = ScanForm.ScanPhoto(UserLatitude, UserLongitude, Photo,
                                                   position, loading, camera, netStatus, sign);
        });
        //Assert для проверки ожидаемого и полученного значения
        Assert.That(actualReturnValue, Is.EqualTo(expectedReturnValue));
    }

        [Test]
        public void T_003_ScanPhoto_PhotoLoadException()
        {
        //подготовка данных
        Double UserLatitude = 41.343464;
        Double UserLongitude = 64.353;
        String Photo = "0";
        bool position = true;
        bool loading = false;
        int camera = 2;
        bool netStatus = true;
        int sign = 2;

        //ожидаемое значение
        String expectedReturnValue = "Failed to load photo";
        //подготовка переменной для полученного значения
        String actualReturnValue = "Fail";
        //Assert для получения исключения
        Assert.DoesNotThrow(() =>
        {
            actualReturnValue = ScanForm.ScanPhoto(UserLatitude, UserLongitude, Photo,
                                                   position, loading, camera, netStatus, sign);
        });
        //Assert для проверки ожидаемого и полученного значения
        Assert.That(actualReturnValue, Is.EqualTo(expectedReturnValue));
    }

        [Test]
        public void T_004_ScanPhoto_PhotoScanFail()
        {
            //подготовка данных
            Double UserLatitude = 41.343464;
            Double UserLongitude = 64.353;
            String Photo = "rgeFGj032FE5";
        bool position = true;
        bool loading = true;
        int camera = 2;
        bool netStatus = true;
        int sign = 0;

        //ожидаемое значение
        String expectedReturnValue = "Recycle not found";
        //подготовка переменной для полученного значения
        String actualReturnValue = "Fail";
        //Assert для получения исключения
        Assert.DoesNotThrow(() =>
        {
            actualReturnValue = ScanForm.ScanPhoto(UserLatitude, UserLongitude, Photo,
                                                   position, loading, camera, netStatus, sign);
        });
        //Assert для проверки ожидаемого и полученного значения
        Assert.That(actualReturnValue, Is.EqualTo(expectedReturnValue));
    }

        [Test]
        public void T_005_ScanPhoto_ScanTimeOut()
        {
            //подготовка данных
            Double UserLatitude = 41.343464;
            Double UserLongitude = 64.353;
            String Photo = "rgeFGj032FE5";
        bool position = true;
        bool loading = true;
        int camera = 2;
        bool netStatus = true;
        int sign = 1;

        //ожидаемое значение
        String expectedReturnValue = "Scanning timed out";
        //подготовка переменной для полученного значения
        String actualReturnValue = "Fail";
        //Assert для получения исключения
        Assert.DoesNotThrow(() =>
        {
            actualReturnValue = ScanForm.ScanPhoto(UserLatitude, UserLongitude, Photo,
                                                   position, loading, camera, netStatus, sign);
        });
        //Assert для проверки ожидаемого и полученного значения
        Assert.That(actualReturnValue, Is.EqualTo(expectedReturnValue));
    }

        [Test]
        public void T_006_ScanPhoto_LostInternetConnection()
        {
            //подготовка данных
            Double UserLatitude = 41.343464;
            Double UserLongitude = 64.353;
            String Photo = "rgeFGj032FE5";
        bool position = true;
        bool loading = true;
        int camera = 2;
        bool netStatus = false;
        int sign = 2;

        //ожидаемое значение
        String expectedReturnValue = "Lost Internet connection";
        //подготовка переменной для полученного значения
        String actualReturnValue = "Fail";
        //Assert для получения исключения
        Assert.DoesNotThrow(() =>
        {
            actualReturnValue = ScanForm.ScanPhoto(UserLatitude, UserLongitude, Photo,
                                                   position, loading, camera, netStatus, sign);
        });
        //Assert для проверки ожидаемого и полученного значения
        Assert.That(actualReturnValue, Is.EqualTo(expectedReturnValue));
    }

        [Test]
        public void T_007_ScanPhoto_CameraUsed()
        {
            //подготовка данных
            Double UserLatitude = 41.343464;
            Double UserLongitude = 64.353;
            String Photo = "rgeFGj032FE5";
        bool position = true;
        bool loading = true;
        int camera = 1;
        bool netStatus = true;
        int sign = 2;

        //ожидаемое значение
        String expectedReturnValue = "Camera is used by another app";
        //подготовка переменной для полученного значения
        String actualReturnValue = "Fail";
        //Assert для получения исключения
        Assert.DoesNotThrow(() =>
        {
            actualReturnValue = ScanForm.ScanPhoto(UserLatitude, UserLongitude, Photo,
                                                   position, loading, camera, netStatus, sign);
        });
        //Assert для проверки ожидаемого и полученного значения
        Assert.That(actualReturnValue, Is.EqualTo(expectedReturnValue));
    }

        [Test]
        public void T_008_ScanPhoto_CameraAccessDenied()
        {
            //подготовка данных
            Double UserLatitude = 41.343464;
            Double UserLongitude = 64.353;
            String Photo = "rgeFGj032FE5";
        bool position = true;
        bool loading = true;
        int camera = 0;
        bool netStatus = true;
        int sign = 2;

        //ожидаемое значение
        String expectedReturnValue = "Camera is unaviable";
        //подготовка переменной для полученного значения
        String actualReturnValue = "Fail";
        //Assert для получения исключения
        Assert.DoesNotThrow(() =>
        {
            actualReturnValue = ScanForm.ScanPhoto(UserLatitude, UserLongitude, Photo,
                                                   position, loading, camera, netStatus, sign);
        });
        //Assert для проверки ожидаемого и полученного значения
        Assert.That(actualReturnValue, Is.EqualTo(expectedReturnValue));
    }

}
