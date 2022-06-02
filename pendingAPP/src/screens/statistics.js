import { auto } from 'async';
import { StatusBar } from 'expo-status-bar';
import { hidden } from 'jest-haste-map/node_modules/chalk';
import { upperCase } from 'lodash';
import { StyleSheet, Text, View, Pressable, Image } from 'react-native';
import { Searchbar } from 'react-native-paper';
import React, { Component } from 'react';
import 'react-native-gesture-handler';
import { ScrollView } from 'react-native-gesture-handler';
import { createBottomTabNavigator } from '@react-navigation/bottom-tabs';
import { NavigationContainer } from '@react-navigation/native';
import HorizontalBarGraph from '@chartiful/react-native-horizontal-bar-graph'


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


                    <View style={styles.containerButton}>

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
                    </View>
                </View>


                <View style={styles.containerStats}>
                    <HorizontalBarGraph
                        data={[ 50, 75, 100, 125]}
                        labels={['Ganhos', 'Devendo', 'Clientes', 'Despesas']}
                        width={350}
                        height={250}
                        barRadius={15}
                        barColor={'#999'}
                        baseConfig={{
                            hasYAxisBackgroundLines: false,
                            xAxisLabelStyle: {
                                rotation: 0,
                                fontSize: 12,
                                width: 85,
                                yOffset: 4,
                                xOffset: -15
                            },
                            yAxisLabelStyle: {
                                rotation: 30,
                                fontSize: 13,
                                prefix: '$',
                                position: 'bottom',
                                xOffset: 15,
                                decimals: 2,
                                height: 100
                            }
                        }}
                    />

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
        marginTop: 30,
        marginLeft: 20,
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
        marginTop: 40,
        marginLeft: 20, 
    },

});
