import { auto } from 'async';
import { StatusBar } from 'expo-status-bar';
import { hidden } from 'jest-haste-map/node_modules/chalk';
import { upperCase } from 'lodash';
import { StyleSheet, Text, View, Pressable, TouchableOpacity, Image } from 'react-native';
import { Searchbar } from 'react-native-paper';
import React, { Component } from 'react';
import 'react-native-gesture-handler';
import { ScrollView } from 'react-native-gesture-handler';
import { createBottomTabNavigator } from '@react-navigation/bottom-tabs';
import { NavigationContainer } from '@react-navigation/native';
import HorizontalBarGraph from '@chartiful/react-native-horizontal-bar-graph';


// import {
//   LineChart,
//   BarChart,
//   PieChart,
//   ProgressChart,
//   ContributionGraph,
//   StackedBarChart
// } from "react-native-chart-kit";


const bottomTab = createBottomTabNavigator();

import Home from './main';


export default class statistics extends React.Component {
    state = {
        firstQuery: '',
    };
    

    render() {
        const { firstQuery } = this.state;

        const Tab = createBottomTabNavigator();

        return (

            <View style={styles.main}>
                <View style={styles.mainHeader}>
                    <View style={styles.container_header}>

                        <View style={styles.total_budget}>
                            <View style={styles.total_budget_text}>
                                <Text style={styles.text_total}>Total</Text>
                                <Text style={styles.text_total2}>+ R$ XXXX,XX</Text>
                            </View>
                        </View>
                    </View>


                    {/* <View style={styles.containerButton}>

                        <View style={styles.containerButton2}>
                            <Pressable style={styles.buttonAdd}>
                                <Text style={styles.textButton}>Meu Sumário</Text>
                            </Pressable>

                            <Pressable style={styles.buttonRemove}>
                                <Text style={styles.textButton}>Pagamentos extras</Text>
                            </Pressable>
                        </View>

                        <View style={styles.containerButton3}>
                            <Pressable style={styles.buttonAdd}>
                                <Text style={styles.textButton}>dd/mm/aa</Text>
                            </Pressable>

                            <Pressable style={styles.buttonRemove}>
                                <Text style={styles.textButton}>Compras extras</Text>
                            </Pressable>
                        </View>
                    </View> */}
                </View>


                <View style={styles.containerStats}>
                    <HorizontalBarGraph style={styles.graph}
                        data={[75, 100, 125,100]}
                        labels={['Lucro', 'Clientes devendo', 'Despesas clientes', 'Despesas Total']}
                        // legend = {["L1", "L2", "L3"]}
                        width={350}
                        height={300}
                        barRadius={15}
                        barColor={'#90C9E3'}
                        barWidthPercentage={0.40}
                        
                        baseConfig={{
                            hasYAxisBackgroundLines: false,
                            hasYAxisLabels: false,
                            xAxisLabelStyle: {
                                rotation: 0,
                                fontSize: 15,
                                width: 150,
                                // height: 150,
                                yOffset: 4,
                                xOffset: -50
                                


                            },
                            // yAxisLabelStyle: {
                            //     rotation: 20,
                            //     fontSize: 13,
                            //     prefix: '$',
                            //     position: 'bottom',
                            //     xOffset: 15,
                            //     // decimals: 2,
                            //      height: 30
                            // }
                        }}
                    />

                </View>

                <View style={styles.navBar}>
                    <TouchableOpacity
                        onPress={() => this.props.navigation.navigate('Main')}>
                        <Image source={require('../assets/Home.png')} />
                    </TouchableOpacity>

                    <TouchableOpacity
                        onPress={() => this.props.navigation.navigate('Settings')}>
                        <Image source={require('../assets/Settings.png')} />
                    </TouchableOpacity>

                    <TouchableOpacity
                        onPress={() => this.props.navigation.navigate('statistics')}>
                        <Image source={require('../assets/Chart.png')} />
                    </TouchableOpacity>

                    <TouchableOpacity
                        onPress={() => this.props.navigation.navigate('Clients')}>
                        <Image source={require('../assets/Client.png')} />
                    </TouchableOpacity>
                </View>

            </View>

        );
    }
}

const styles = StyleSheet.create({
    main: {
        flex: 1,
        backgroundColor: '#F4F4F4',
    },

    text: {
        fontSize: 23,
        fontWeight: '700',
        color: '#000',
        textTransform: 'uppercase',
    },

    total_budget: {
        marginTop: 80,
        marginLeft: 40,
    },

    total_budget_text: {
        height: 'auto',
        width: 'auto',
        alignItems: 'flex-start',
    },

    text_total: {
        fontSize: 20,
        fontWeight: '600',
        color: 'rgba(34, 34, 34, 0.6)',
    },

    text_total2: {
        fontSize: 35,
        fontWeight: 'bold',
        color: '#222222',
    },

    containerButton: {
        marginTop: 20,
        justifyContent: 'space-between',
        flexDirection: 'row',
        marginLeft: 20,
        marginRight: 20,
    },

    buttonAdd: {
        width: 165,
        height: 40,
        alignItems: 'center',
        justifyContent: 'center',
        borderRadius: 20,
        backgroundColor: '#90C9E3',
        marginBottom: 10,
    },

    buttonRemove: {
        width: 165,
        height: 40,
        alignItems: 'center',
        justifyContent: 'center',
        borderRadius: 20,
        backgroundColor: '#222222',
    },

    textButton: {
        fontSize: 12,
        fontWeight: '700',
        color: 'white',
        textTransform: 'uppercase',
    },

    containerStats: {
        marginTop: 50,
        marginLeft: 30, 
        // height: 10,
        
    },

    // labels: {
    //     fontSize: 12,
    //     fontWeight: '700',
    //     color: 'white',
    //     textTransform: 'uppercase',
    // }

    navBar: {
        width: 360,
        height: 60,
        backgroundColor: '#222222',
        borderRadius: 20,
        marginBottom: 60,
        flexDirection: 'row',
        alignSelf: 'center',
        alignItems: 'center',
        justifyContent: 'space-around',
        position: 'absolute',
        bottom: 0,
    },

    // graph:{
    //     fontSize: 12,
    //     fontWeight: '700',
    //     color: 'white',
    //     textTransform: 'uppercase',
    // }

});
