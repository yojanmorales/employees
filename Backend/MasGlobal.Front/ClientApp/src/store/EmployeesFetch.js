const requestEmployeeType = 'REQUEST_EMPLOYEES';
const receiveEmployeeType = 'RECEIVE_EMPLOYEES';
const initialState = { forecasts: [], isLoading: false };

export const actionCreators = {
  requestEmployee: () => async (dispatch, getState) => {    
   
    dispatch({ type: requestEmployeeType });

    const url = `https://localhost:44372/odata/employees`;
    const response = await fetch(url);
      const employees = await response.json();

      dispatch({ type: receiveEmployeeType, employees });
  }
};

export const reducer = (state, action) => {
  state = state || initialState;

  if (action.type === requestEmployeeType) {
    return {
      ...state,
      isLoading: true
    };
  }

  if (action.type === receiveEmployeeType) {
    return {
      ...state,
        employees: action.employees,
      isLoading: false
    };
  }

  return state;
};
