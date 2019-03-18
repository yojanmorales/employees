import axios from 'axios';
import * as types from '../actions/actionTypes';


export function setEmployees(employees) {
    return { type: types.SET_EMPLOYEES, employees};
}

export function ajaxLoading(status) {
    return { type: types.AJAX_LOADING, status};
}

export function getEmployees() {
    return dispatch => {
        dispatch(ajaxLoading(true));
        axios.get('https://localhost:44372/odata/employees')
            .then(response => {
                dispatch(setEmployees(response.data.value));
                dispatch(ajaxLoading(false));
            })
            .catch(error => {
                console.error(error);
                dispatch(ajaxLoading(false));
            });
    };
}

export function getEmployeesbyId(id) {
    return dispatch => {
        dispatch(ajaxLoading(true));
        axios.get('https://localhost:44372/odata/employees?$filter=Id eq '+ id)
            .then(response => {
                dispatch(setEmployees(response.data.value));
                dispatch(ajaxLoading(false));
            })
            .catch(error => {
                console.error(error);
                dispatch(ajaxLoading(false));
            });
    };
}