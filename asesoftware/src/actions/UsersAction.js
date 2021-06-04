import HttpClient from '../Services/HttpClient';

export const getUsers = () => {
    return new Promise((resolve, eject) => {
        HttpClient.get('/User').then(response => {
            resolve(response);
        });
    });
}