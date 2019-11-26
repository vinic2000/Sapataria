class Data {

    constructor() {
        this.data = new Date();
    }

    ArrumarData(dataEnviada) {

        var data = new Date(dataEnviada);
        return `${data.getDate()}/${data.getMonth()}/${data.getFullYear()}`;
    }

    OrganizarDatas(dataEnviada) {
        var data = new Date(dataEnviada);
        console.log(data.getDate());

        if (data.getDate() <= this.data.getDate()) {
            if (data.getMonth() <= this.data.getMonth()) {
                if (data.getFullYear() <= this.data.getFullYear()) {
                    return true;
                }
            }
        }
    }
}