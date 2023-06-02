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
            //���������� ������
            Double UserLatitude = 41.343464;
            Double UserLongitude = 64.353;
            String Photo = "fgvreyetuj45";
            

            bool position = true;
            bool loading = true;
            int camera = 2;
            bool netStatus = true;
            int sign = 2;

            //��������� ��������
            String expectedReturnValue = "Success";
            //���������� ���������� ��� ����������� ��������
            String actualReturnValue = "Fail";
            //Assert ��� ��������� ����������
        Assert.DoesNotThrow(() =>
            {
                actualReturnValue = ScanForm.ScanPhoto(UserLatitude, UserLongitude, Photo,
                                                       position, loading, camera, netStatus, sign);
            });
            //Assert ��� �������� ���������� � ����������� ��������
            Assert.That(actualReturnValue, Is.EqualTo(expectedReturnValue));
    }

        [Test]
        public void T_002_ScanPhoto_PositionFail()
        {
            //���������� ������
            Double UserLatitude = 0;
            Double UserLongitude = 0;
            String Photo = "sthrt4563dh";
        bool position = false;
        bool loading = true;
        int camera = 2;
        bool netStatus = true;
        int sign = 2;

        //��������� ��������
        String expectedReturnValue = "Failed to determine position";
        //���������� ���������� ��� ����������� ��������
        String actualReturnValue = "Fail";
        //Assert ��� ��������� ����������
        Assert.DoesNotThrow(() =>
        {
            actualReturnValue = ScanForm.ScanPhoto(UserLatitude, UserLongitude, Photo,
                                                   position, loading, camera, netStatus, sign);
        });
        //Assert ��� �������� ���������� � ����������� ��������
        Assert.That(actualReturnValue, Is.EqualTo(expectedReturnValue));
    }

        [Test]
        public void T_003_ScanPhoto_PhotoLoadException()
        {
        //���������� ������
        Double UserLatitude = 41.343464;
        Double UserLongitude = 64.353;
        String Photo = "0";
        bool position = true;
        bool loading = false;
        int camera = 2;
        bool netStatus = true;
        int sign = 2;

        //��������� ��������
        String expectedReturnValue = "Failed to load photo";
        //���������� ���������� ��� ����������� ��������
        String actualReturnValue = "Fail";
        //Assert ��� ��������� ����������
        Assert.DoesNotThrow(() =>
        {
            actualReturnValue = ScanForm.ScanPhoto(UserLatitude, UserLongitude, Photo,
                                                   position, loading, camera, netStatus, sign);
        });
        //Assert ��� �������� ���������� � ����������� ��������
        Assert.That(actualReturnValue, Is.EqualTo(expectedReturnValue));
    }

        [Test]
        public void T_004_ScanPhoto_PhotoScanFail()
        {
            //���������� ������
            Double UserLatitude = 41.343464;
            Double UserLongitude = 64.353;
            String Photo = "rgeFGj032FE5";
        bool position = true;
        bool loading = true;
        int camera = 2;
        bool netStatus = true;
        int sign = 0;

        //��������� ��������
        String expectedReturnValue = "Recycle not found";
        //���������� ���������� ��� ����������� ��������
        String actualReturnValue = "Fail";
        //Assert ��� ��������� ����������
        Assert.DoesNotThrow(() =>
        {
            actualReturnValue = ScanForm.ScanPhoto(UserLatitude, UserLongitude, Photo,
                                                   position, loading, camera, netStatus, sign);
        });
        //Assert ��� �������� ���������� � ����������� ��������
        Assert.That(actualReturnValue, Is.EqualTo(expectedReturnValue));
    }

        [Test]
        public void T_005_ScanPhoto_ScanTimeOut()
        {
            //���������� ������
            Double UserLatitude = 41.343464;
            Double UserLongitude = 64.353;
            String Photo = "rgeFGj032FE5";
        bool position = true;
        bool loading = true;
        int camera = 2;
        bool netStatus = true;
        int sign = 1;

        //��������� ��������
        String expectedReturnValue = "Scanning timed out";
        //���������� ���������� ��� ����������� ��������
        String actualReturnValue = "Fail";
        //Assert ��� ��������� ����������
        Assert.DoesNotThrow(() =>
        {
            actualReturnValue = ScanForm.ScanPhoto(UserLatitude, UserLongitude, Photo,
                                                   position, loading, camera, netStatus, sign);
        });
        //Assert ��� �������� ���������� � ����������� ��������
        Assert.That(actualReturnValue, Is.EqualTo(expectedReturnValue));
    }

        [Test]
        public void T_006_ScanPhoto_LostInternetConnection()
        {
            //���������� ������
            Double UserLatitude = 41.343464;
            Double UserLongitude = 64.353;
            String Photo = "rgeFGj032FE5";
        bool position = true;
        bool loading = true;
        int camera = 2;
        bool netStatus = false;
        int sign = 2;

        //��������� ��������
        String expectedReturnValue = "Lost Internet connection";
        //���������� ���������� ��� ����������� ��������
        String actualReturnValue = "Fail";
        //Assert ��� ��������� ����������
        Assert.DoesNotThrow(() =>
        {
            actualReturnValue = ScanForm.ScanPhoto(UserLatitude, UserLongitude, Photo,
                                                   position, loading, camera, netStatus, sign);
        });
        //Assert ��� �������� ���������� � ����������� ��������
        Assert.That(actualReturnValue, Is.EqualTo(expectedReturnValue));
    }

        [Test]
        public void T_007_ScanPhoto_CameraUsed()
        {
            //���������� ������
            Double UserLatitude = 41.343464;
            Double UserLongitude = 64.353;
            String Photo = "rgeFGj032FE5";
        bool position = true;
        bool loading = true;
        int camera = 1;
        bool netStatus = true;
        int sign = 2;

        //��������� ��������
        String expectedReturnValue = "Camera is used by another app";
        //���������� ���������� ��� ����������� ��������
        String actualReturnValue = "Fail";
        //Assert ��� ��������� ����������
        Assert.DoesNotThrow(() =>
        {
            actualReturnValue = ScanForm.ScanPhoto(UserLatitude, UserLongitude, Photo,
                                                   position, loading, camera, netStatus, sign);
        });
        //Assert ��� �������� ���������� � ����������� ��������
        Assert.That(actualReturnValue, Is.EqualTo(expectedReturnValue));
    }

        [Test]
        public void T_008_ScanPhoto_CameraAccessDenied()
        {
            //���������� ������
            Double UserLatitude = 41.343464;
            Double UserLongitude = 64.353;
            String Photo = "rgeFGj032FE5";
        bool position = true;
        bool loading = true;
        int camera = 0;
        bool netStatus = true;
        int sign = 2;

        //��������� ��������
        String expectedReturnValue = "Camera is unaviable";
        //���������� ���������� ��� ����������� ��������
        String actualReturnValue = "Fail";
        //Assert ��� ��������� ����������
        Assert.DoesNotThrow(() =>
        {
            actualReturnValue = ScanForm.ScanPhoto(UserLatitude, UserLongitude, Photo,
                                                   position, loading, camera, netStatus, sign);
        });
        //Assert ��� �������� ���������� � ����������� ��������
        Assert.That(actualReturnValue, Is.EqualTo(expectedReturnValue));
    }

}
