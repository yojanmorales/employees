import { combineReducers } from 'redux';
// Reducers
import employees from './employeesReducer';
import ajaxLoading from './ajaxLoadingReducer';

const rootReducer = combineReducers({
    employees,
    ajaxLoading
});

export default rootReducer;