import axios from 'axios';

axios.defaults.baseURL = "http://localhost:5000/api";

const requestAPI = {
    get: (url) => axios.get(url),
}

export default requestAPI;