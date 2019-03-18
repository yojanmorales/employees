import * as types from '../actions/actionTypes';
import initialState from '../store/initialState';

export default function employeesReducer(state = initialState.employees, action) {
    switch (action.type) {
        case types.SET_EMPLOYEES:
            return action.employees;       
        default:
            return state;
    }
}